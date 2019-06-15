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
using Game_items_selling_forms.Admin;
using Game_items_selling_forms.Change;

namespace Game_items_selling_forms.Developer
{
    public partial class DeveloperForm : Form
    {
        Разработчики maindev;       
        string databasevalue;
        

        public DeveloperForm(Разработчики dev)
        {
            InitializeComponent();
            DevName.Text = dev.Название;
            maindev = dev;
        }

        private void ВыходВМенюАвторизацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

            foreach (Игры game in entity.Игры)
            {
                if (game.Код_разработчика == maindev.Код_разработчика)
                {
                    foreach (Предметы_из_игр gameitem in game.Предметы_из_игр)
                    {
                        foreach (Чек order in gameitem.Чек)
                        {
                            Database.Rows.Add(
                                order.Код_чека,
                                order.Торговые_площадки.Название,
                                order.Предметы_из_игр.Название,
                                order.Предметы_из_игр.Игры.Название,
                                order.Предметы_из_игр.Игры.Разработчики.Название,
                                order.Дата,
                                order.Кол_во_предметов,
                                order.Кол_во_предметов * order.Предметы_из_игр.Цена,
                                order.Предметы_из_игр.Валюты.Название);
                        }
                    }
                }
            }           
        }

        private void ShowGames_Click(object sender, EventArgs e)
        {
            Game_items_tradingEnt entity = new Game_items_tradingEnt();
            databasevalue = "games";
            Database.Rows.Clear();
            Database.Columns.Clear();

            Database.ColumnCount = 12;
            Database.ColumnHeadersVisible = true;

            Database.Columns[0].Name = "Код игры";
            Database.Columns[1].Name = "Название игры";
            Database.Columns[2].Name = "Движок";
            Database.Columns[3].Name = "Дата создания";
            Database.Columns[4].Name = "Платформа";
            Database.Columns[5].Name = "Разработчик";
            Database.Columns[6].Name = "Жанр";
            Database.Columns[7].Name = "Издатель";
            Database.Columns[8].Name = "Название рейтинга";
            Database.Columns[9].Name = "Рейтинг";
            Database.Columns[10].Name = "Кол-во игр";

            foreach (Игры game in entity.Игры)
            {
                if (game.Код_разработчика == maindev.Код_разработчика)
                {
                    foreach (Издатель p in game.Издатель)
                    {
                        foreach (Возрастной_рейтинг r in game.Возрастной_рейтинг)
                        {
                            Database.Rows.Add(
                            game.Код_игры,
                            game.Название,
                            game.Движок,
                            game.Дата_создания,
                            game.Платформы.Название,
                            game.Разработчики.Название,
                            game.Жанры.Название,
                            p.Название,
                            r.Название_рейтинга,
                            r.Рейтинг,
                            game.Предметы_из_игр.Count());
                        }
                    }
                }
            }
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

            foreach (Игры game in entity.Игры)
            {
                if (game.Код_разработчика == maindev.Код_разработчика)
                {
                    foreach (Предметы_из_игр item in game.Предметы_из_игр)
                    {
                        Database.Rows.Add(
                            item.Код_предмета,
                            item.Название,
                            item.Редкость,
                            item.Валюты.Название,
                            item.Цена,
                            item.Количество,
                            item.Игры.Название,
                            item.Чек.Count);
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

        private void DeleteAcc_Click(object sender, EventArgs e)
        {
            Game_items_tradingEnt entity = new Game_items_tradingEnt();
            Разработчики dev = entity.Разработчики.FirstOrDefault(a => a.Код_разработчика == maindev.Код_разработчика);
            entity.Разработчики.Remove(dev);
            entity.SaveChanges();
            MessageBox.Show("Ваш аккаунт удалён");
            EntryForm Entry = new EntryForm();
            Close();
            Entry.Show();
        }

        private void AddGame_Click(object sender, EventArgs e)
        {
            AddGame game = new AddGame(maindev.Код_разработчика);
            game.ShowDialog();
            ShowGames_Click(sender, e);
        }

        private void AddGameItem_Click(object sender, EventArgs e)
        {
            if (databasevalue == "games")
            {
                DataGridViewSelectedRowCollection Datalist = Database.SelectedRows;
                AddGameItem item = new AddGameItem(Datalist);
                item.ShowDialog();
                ShowGameItems_Click(sender, e);
            }
            else MessageBox.Show("Выберите игру для добавления игрового предмета");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Game_items_tradingEnt entity = new Game_items_tradingEnt();
            if (databasevalue == "games" || databasevalue == "gameitems")
            {
                DataGridViewSelectedRowCollection Datalist = Database.SelectedRows;

                foreach (DataGridViewRow row in Datalist)
                {
                    if (row.Cells[0].Value is Int32)
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value);
                        if (databasevalue == "games")
                        {
                            Игры game = entity.Игры.FirstOrDefault(a => a.Код_игры == id);
                            Разработчики dev = game.Разработчики;
                            entity.Игры.Remove(game);                           
                            entity.SaveChanges();
                            ShowGames_Click(sender, e);
                            if (dev.Игры.Count == 0)
                            {
                                DeleteAcc_Click(sender, e);
                            }
                        }
                        else if (databasevalue == "gameitems")
                        {
                            Предметы_из_игр gameitem = entity.Предметы_из_игр.FirstOrDefault(a => a.Код_предмета == id);
                            entity.Предметы_из_игр.Remove(gameitem);
                            entity.SaveChanges();
                            ShowGameItems_Click(sender, e);
                        }                       
                        else { MessageBox.Show("Ошибка в программных названиях таблиц"); break; }
                    }
                    else { MessageBox.Show("Эти данные удалять нельзя"); }
                }
            }
            else { MessageBox.Show("Эти данные удалять нельзя"); }
        }

        private void ChangeAcc_Click(object sender, EventArgs e)
        {
            Game_items_tradingEnt entity = new Game_items_tradingEnt();
            string name = maindev.Название;
            ChangeDeveloper changeDeveloper = new ChangeDeveloper(maindev.Код_разработчика);
            changeDeveloper.ShowDialog();
            maindev = entity.Разработчики.FirstOrDefault(a => a.Код_разработчика == maindev.Код_разработчика);
            if (maindev.Название != name) { MessageBox.Show($"Внимание! Ваш логин изменился!\nВаш новый логин: {maindev.Код_разработчика}_{maindev.Название}"); }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (databasevalue == "games" || databasevalue == "gameitems")
            {
                DataGridViewRow row = Database.SelectedRows[0];

                if (row.Cells[0].Value is Int32)
                {
                    int id = Convert.ToInt32(row.Cells[0].Value);
                    if (databasevalue == "games")
                    {
                        ChangeGame changeGame = new ChangeGame(id);
                        changeGame.ShowDialog();

                        ShowGames_Click(sender, e);
                    }
                    else if (databasevalue == "gameitems")
                    {
                        ChangeGameItem changeGameItem = new ChangeGameItem(id);
                        changeGameItem.ShowDialog();
                        ShowGameItems_Click(sender, e);
                    }
                }
                else {MessageBox.Show("Эти данные изменять нельзя");}
            }
            else { MessageBox.Show("Эти данные изменять нельзя"); }
        }

        private void СправкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для просмотра данных нажмите на любую кнопку просмотра справа от поля вывода данных.\n" +
               "Перед тем, как добавить игру, выберите разработчика. Перед тем, как добавить игровой предмет, выберите игру.\n" +
               "Для редактирования данных выберите 1 поле (не все поля можно редактировать - только те, которые можно добавлять).\n" +
               "Для удаления данных выберите поле (поля) и нажмите на кнопку удаления (не все данные можно удалить).\n" +
               "Для импорта в Excel откройте нужную таблицу и нажмите на кнопку импорта.\n" +
               "Для редактирования/удаления аккаунта нажмите на соответствующие кнопки.\n" +
               "Можно изменить кол-во копий игровых предметов через кнопку редактирования.\n" +
               "При редактировании можно не заполнять все поля.\n" +
               "Для выхода нажмите на кнопку выхода в меню авторизации.");
        }
    }
}
