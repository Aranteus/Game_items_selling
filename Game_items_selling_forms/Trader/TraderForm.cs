using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Game_items_selling_forms.Change;

namespace Game_items_selling_forms.Trader
{
    public partial class TraderForm : Form
    {
        Торговые_площадки maintrader;       
        string databasevalue;

        public TraderForm(Торговые_площадки trader)
        {
            InitializeComponent();
            maintrader = trader;
            TraderName.Text = trader.Торговая_площадка;
        }

        private void ВыходВМенюАвторизацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntryForm Entry = new EntryForm();
            Close();
            Entry.Show();
        }

        private void DeleteAcc_Click(object sender, EventArgs e)
        {
            Game_items_tradingEnt entity = new Game_items_tradingEnt();
            Торговые_площадки trader = entity.Торговые_площадки.FirstOrDefault(a => a.Код_торговой_площадки == maintrader.Код_торговой_площадки);
            entity.Торговые_площадки.Remove(trader);
            entity.SaveChanges();
            MessageBox.Show("Ваш аккаунт удалён");
            EntryForm Entry = new EntryForm();
            Close();
            Entry.Show();
        }

        private void ShowOrders_Click(object sender, EventArgs e)
        {
            Game_items_tradingEnt entity = new Game_items_tradingEnt();
            databasevalue = "orders";
            Database.Rows.Clear();
            Database.Columns.Clear();

            Database.ColumnCount = 10;
            Database.ColumnHeadersVisible = true;

            Database.Columns[0].Name = "Код чека";
            Database.Columns[1].Name = "Название фирмы";
            Database.Columns[2].Name = "Название предмета";
            Database.Columns[3].Name = "Игра";
            Database.Columns[4].Name = "Разработчик";
            Database.Columns[5].Name = "Дата";
            Database.Columns[6].Name = "Кол-во предметов";
            Database.Columns[7].Name = "Цена";
            Database.Columns[8].Name = "Валюта";

            foreach (Торговые_площадки trader in entity.Торговые_площадки)
            {
                if (trader.Код_торговой_площадки == maintrader.Код_торговой_площадки)
                {
                    foreach (Чек order in trader.Чек)
                    {
                        Database.Rows.Add(
                            order.Код_чека,
                            order.Торговые_площадки.Торговая_площадка,
                            order.Предметы_из_игр.Игровой_предмет,
                            order.Предметы_из_игр.Игры.Игра,
                            order.Предметы_из_игр.Игры.Разработчики.Разработчик,
                            order.Дата,
                            order.Кол_во_предметов,
                            order.Кол_во_предметов * order.Предметы_из_игр.Цена,
                            order.Предметы_из_игр.Валюты.Валюта);
                    }
                }
            }    
        }

        private void ImportExcel_Click(object sender, EventArgs e)
        {
            if (Database.ColumnCount != 0)
            {
                _Application excelapp = new Microsoft.Office.Interop.Excel.Application
                {
                    Visible = false
                };
                Workbook workbook = excelapp.Workbooks.Add(Type.Missing);
                Worksheet worksheet = null;

                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Exported from Database";
                worksheet.Application.DisplayAlerts = false;

                for (int i = 1; i < Database.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = Database.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < Database.RowCount; i++)
                {
                    for (int a = 0; a < Database.ColumnCount; a++)
                    {
                        worksheet.Cells[i + 2, a + 1] = Database.Rows[i].Cells[a].Value;
                    }
                }
                string xml = Environment.CurrentDirectory + "\\" + databasevalue + ".xls";
                int copy = 1;
                string pathvalue = databasevalue + ".xls";
                while (File.Exists(xml) != false)
                {
                    xml = xml.Replace(pathvalue, databasevalue + Convert.ToString(copy) + ".xls");
                    pathvalue = databasevalue + Convert.ToString(copy) + ".xls";
                    copy++;
                }
                worksheet.SaveAs(xml, Type.Missing, Type.Missing, Type.Missing, true, false, false, Type.Missing, Type.Missing, Type.Missing);
                excelapp.Quit();
                MessageBox.Show("Excel документ сохранён в рабочей папке: " + xml);
            }
            else MessageBox.Show("Пустое окно данных. Пожалуйста, выберите данные, нажав на кнопки просмотра.");
        }

        private void BuyGameItem_Click(object sender, EventArgs e)
        {
            Game_items_tradingEnt entity = new Game_items_tradingEnt();
            if (databasevalue == "gameitems")
            {
                if (GameItemNumber.Value > 0)
                {
                    DataGridViewRow row = Database.SelectedRows[0];

                    if (row.Cells[0].Value is Int32)
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value);
                        Предметы_из_игр gameitem = entity.Предметы_из_игр.FirstOrDefault(a => a.Код_предмета == id);
                        Торговые_площадки trader = entity.Торговые_площадки.FirstOrDefault(a => a.Код_торговой_площадки == maintrader.Код_торговой_площадки);
                        if (gameitem.Количество >= GameItemNumber.Value)
                        {
                            Чек order = new Чек
                            {
                                Дата = DateTime.Now,
                                Кол_во_предметов = (int)GameItemNumber.Value,
                                Торговые_площадки = trader
                            };
                            gameitem.Чек.Add(order);
                            gameitem.Количество -= (int)GameItemNumber.Value;
                            entity.SaveChanges();
                            ShowGameItems_Click(sender, e);
                        }
                        else MessageBox.Show("Нельзя купить столько предметов");
                    }
                }
                else MessageBox.Show("Нельзя купить столько игровых предметов");
            }
            else MessageBox.Show("Выберите игровой предмет");
        }

        private void ShowGameItems_Click(object sender, EventArgs e)
        {
            Game_items_tradingEnt entity = new Game_items_tradingEnt();
            databasevalue = "gameitems";
            Database.Rows.Clear();
            Database.Columns.Clear();

            Database.ColumnCount = 9;
            Database.ColumnHeadersVisible = true;

            Database.Columns[0].Name = "Код предмета";
            Database.Columns[1].Name = "Название предмета";
            Database.Columns[2].Name = "Редкость";
            Database.Columns[3].Name = "Валюта";
            Database.Columns[4].Name = "Цена";
            Database.Columns[5].Name = "Количество предметов";
            Database.Columns[6].Name = "Название игры";
            Database.Columns[7].Name = "Количество заказов";

            foreach (Предметы_из_игр item in entity.Предметы_из_игр)
            {
                Database.Rows.Add(
                    item.Код_предмета,
                    item.Игровой_предмет,
                    item.Редкость,
                    item.Валюты.Валюта,
                    item.Цена,
                    item.Количество,
                    item.Игры.Игра,
                    item.Чек.Count);
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            Game_items_tradingEnt entity = new Game_items_tradingEnt();
            string name = maintrader.Торговая_площадка;
            ChangeTrader changeTrader = new ChangeTrader(maintrader.Код_торговой_площадки);
            changeTrader.ShowDialog();
            maintrader = entity.Торговые_площадки.FirstOrDefault(a => a.Код_торговой_площадки == maintrader.Код_торговой_площадки);
            if (maintrader.Торговая_площадка != name) { MessageBox.Show($"Внимание! Ваш логин изменился!\nВаш новый логин: {maintrader.Код_торговой_площадки}_{maintrader.Торговая_площадка}"); }
        }

        private void СправкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для просмотра данных нажмите на любую кнопку просмотра справа от поля вывода данных.\n" +
               "Перед тем, как добавить игру, выберите разработчика. Перед тем, как добавить игровой предмет, выберите игру.\n" +
               "Для импорта в Excel откройте нужную таблицу и нажмите на кнопку импорта.\n" +
               "Для редактирования/удаления аккаунта нажмите на соответствующие кнопки.\n" +
               "Можно изменить кол-во копий игровых предметов через кнопку редактирования.\n" +
               "При редактировании можно не заполнять все поля.\n" +
               "Для покупки игрового предмета выберите его, введите кол-во копий для покупки и нажмите на кнопку.\n" +
               "Внимание: нельзя покупать предметов больше, чем есть в наличии." +
               "Для выхода нажмите на кнопку выхода в меню авторизации.");
        }
    }
}
