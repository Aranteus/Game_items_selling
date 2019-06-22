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
using Game_items_selling_forms.Change;
using Game_items_selling_forms.Admin;
using Microsoft.Office.Interop.Excel;

namespace Game_items_selling_forms
{
    public partial class AdminForm : Form
    {       
        string databasevalue;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void Database_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ВыйтиВМенюАвторизацииToolStripMenuItem_Click(object sender, EventArgs e)
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

            foreach (var order in entity.Чек)
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
            Database.Columns[7].Name = "Издатели";
            Database.Columns[8].Name = "Название рейтинга";
            Database.Columns[9].Name = "Рейтинг";
            Database.Columns[10].Name = "Кол-во игр";

            foreach (Игры game in entity.Игры)
            {
                foreach (Издатели p in game.Издатели)
                {
                    foreach (Возрастной_рейтинг r in game.Возрастной_рейтинг)
                    {
                        Database.Rows.Add(
                        game.Код_игры,
                        game.Игра,
                        game.Движок,
                        game.Дата_создания,
                        game.Платформы.Платформа,
                        game.Разработчики.Разработчик,
                        game.Жанры.Жанр,
                        p.Издатели,
                        r.Название_рейтинга,
                        r.Рейтинг,
                        game.Предметы_из_игр.Count());
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
        private void ShowDevelopers_Click(object sender, EventArgs e)
        {
            Game_items_tradingEnt entity = new Game_items_tradingEnt();
            databasevalue = "developers";
            Database.Rows.Clear();
            Database.Columns.Clear();

            Database.ColumnCount = 6;
            Database.ColumnHeadersVisible = true;

            Database.Columns[0].Name = "Код разработчика";
            Database.Columns[1].Name = "Название разработчика";
            Database.Columns[2].Name = "Дата основания";
            Database.Columns[3].Name = "Кол-во сотрудников";
            Database.Columns[4].Name = "Кол-во игр";

            foreach (Разработчики dev in entity.Разработчики)
            {
                Database.Rows.Add(
                    dev.Код_разработчика,
                    dev.Разработчик,
                    dev.Дата_основания,
                    dev.Кол_во_сотрудников,
                    dev.Игры.Count);
            }
        }
        private void ShowTraders_Click(object sender, EventArgs e)
        {
            Game_items_tradingEnt entity = new Game_items_tradingEnt();
            databasevalue = "traders";
            Database.Rows.Clear();
            Database.Columns.Clear();

            Database.ColumnCount = 6;
            Database.ColumnHeadersVisible = true;

            Database.Columns[0].Name = "Код торговой площадки";
            Database.Columns[1].Name = "Название торговой площадки";
            Database.Columns[2].Name = "Дата создания";
            Database.Columns[3].Name = "Страна";
            Database.Columns[4].Name = "Кол-во заказов";

            foreach (Торговые_площадки trade in entity.Торговые_площадки)
            {
                Database.Rows.Add(
                    trade.Код_торговой_площадки,
                    trade.Торговая_площадка,
                    trade.Дата_создания,
                    trade.Страны.Страна,
                    trade.Чек.Count);
            }
        }
        private void ShowCurrency_Click(object sender, EventArgs e)
        {
            Game_items_tradingEnt entity = new Game_items_tradingEnt();
            databasevalue = "currencies";
            Database.Rows.Clear();
            Database.Columns.Clear();

            Database.ColumnCount = 4;
            Database.ColumnHeadersVisible = true;

            Database.Columns[0].Name = "Буквенный код валюты";
            Database.Columns[1].Name = "Валюта";
            Database.Columns[2].Name = "Кол-во игровых предметов";

            foreach (Валюты curr in entity.Валюты)
            {
                Database.Rows.Add(
                    curr.Буквенный_код_валюты,
                    curr.Валюта,
                    curr.Предметы_из_игр.Count);
            }
        }
        private void ShowAgeRating_Click(object sender, EventArgs e)
        {
            Game_items_tradingEnt entity = new Game_items_tradingEnt();
            databasevalue = "ageratings";
            Database.Rows.Clear();
            Database.Columns.Clear();

            Database.ColumnCount = 5;
            Database.ColumnHeadersVisible = true;

            Database.Columns[0].Name = "Код возрастного рейтинга";
            Database.Columns[1].Name = "Название рейтинга";
            Database.Columns[2].Name = "Рейтинг";
            Database.Columns[3].Name = "Кол-во игр";

            foreach (Возрастной_рейтинг rating in entity.Возрастной_рейтинг)
            {
                Database.Rows.Add(
                    rating.Код_возрастного_рейтинга,
                    rating.Название_рейтинга,
                    rating.Рейтинг,
                    rating.Игры.Count);
            }
            Database.Sort(Database.Columns[1], ListSortDirection.Ascending);
        }
        private void ShowGenre_Click(object sender, EventArgs e)
        {
            Game_items_tradingEnt entity = new Game_items_tradingEnt();
            databasevalue = "genres";
            Database.Rows.Clear();
            Database.Columns.Clear();

            Database.ColumnCount = 4;
            Database.ColumnHeadersVisible = true;

            Database.Columns[0].Name = "Код жанра";
            Database.Columns[1].Name = "Жанр";
            Database.Columns[2].Name = "Кол-во игр";

            foreach (Жанры genre in entity.Жанры)
            {
                Database.Rows.Add(
                    genre.Код_жанра,
                    genre.Жанр,
                    genre.Игры.Count);
            }
        }
        private void ShowPublisher_Click(object sender, EventArgs e)
        {
            Game_items_tradingEnt entity = new Game_items_tradingEnt();
            databasevalue = "publishers";
            Database.Rows.Clear();
            Database.Columns.Clear();

            Database.ColumnCount = 5;
            Database.ColumnHeadersVisible = true;

            Database.Columns[0].Name = "Код издателя";
            Database.Columns[1].Name = "Издатели";
            Database.Columns[2].Name = "Страна";
            Database.Columns[3].Name = "Кол-во игр";

            foreach (Издатели publ in entity.Издатели)
            {
                Database.Rows.Add(
                    publ.Код_издателя,
                    publ.Издатели,
                    publ.Страны.Страна,
                    publ.Игры.Count);
            }
        }
        private void ShowPlatform_Click(object sender, EventArgs e)
        {
            Game_items_tradingEnt entity = new Game_items_tradingEnt();
            databasevalue = "platforms";
            Database.Rows.Clear();
            Database.Columns.Clear();

            Database.ColumnCount = 4;
            Database.ColumnHeadersVisible = true;

            Database.Columns[0].Name = "Код платформы";
            Database.Columns[1].Name = "Платформа";
            Database.Columns[2].Name = "Кол-во игр";

            foreach (Платформы plat in entity.Платформы)
            {
                Database.Rows.Add(
                    plat.Код_платформы,
                    plat.Платформа,
                    plat.Игры.Count);
            }
        }
        private void ShowCountry_Click(object sender, EventArgs e)
        {
            Game_items_tradingEnt entity = new Game_items_tradingEnt();
            databasevalue = "countries";
            Database.Rows.Clear();
            Database.Columns.Clear();

            Database.ColumnCount = 5;
            Database.ColumnHeadersVisible = true;

            Database.Columns[0].Name = "Буквенный код страны";
            Database.Columns[1].Name = "Страна";
            Database.Columns[2].Name = "Кол-во издателей";
            Database.Columns[3].Name = "Кол-во торговых площадок";

            foreach (Страны country in entity.Страны)
            {
                Database.Rows.Add(
                    country.Буквенный_код_страны,
                    country.Страна,
                    country.Издатели.Count,
                    country.Торговые_площадки.Count);
            }
        }

        private void AddTraders_Click(object sender, EventArgs e)
        {
            AddTrader trader = new AddTrader("");
            trader.ShowDialog();
            ShowTraders_Click(sender, e);
        }
        private void AddDeveloper_Click(object sender, EventArgs e)
        {
            AddDeveloper developer = new AddDeveloper("");
            developer.ShowDialog();
            ShowDevelopers_Click(sender, e);
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

        private void Delete_Click(object sender, EventArgs e)
        {
            Game_items_tradingEnt entity = new Game_items_tradingEnt();
            if (databasevalue == "games" || databasevalue == "gameitems" || databasevalue == "developers" ||
                databasevalue == "traders" || databasevalue == "ageratings" || databasevalue == "publishers")
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
                            if (dev.Игры.Count == 0) { entity.Разработчики.Remove(dev); }
                            entity.SaveChanges();
                            ShowGames_Click(sender, e);
                        }
                        else if (databasevalue == "gameitems")
                        {
                            Предметы_из_игр gameitem = entity.Предметы_из_игр.FirstOrDefault(a => a.Код_предмета == id);
                            entity.Предметы_из_игр.Remove(gameitem);
                            entity.SaveChanges();
                            ShowGameItems_Click(sender, e);
                        }
                        else if (databasevalue == "developers")
                        {
                            Разработчики dev = entity.Разработчики.FirstOrDefault(a => a.Код_разработчика == id);
                            entity.Разработчики.Remove(dev);
                            entity.SaveChanges();
                            ShowDevelopers_Click(sender, e);
                        }
                        else if (databasevalue == "traders")
                        {
                            Торговые_площадки trader = entity.Торговые_площадки.FirstOrDefault(a => a.Код_торговой_площадки == id);
                            entity.Торговые_площадки.Remove(trader);
                            entity.SaveChanges();
                            ShowTraders_Click(sender, e);
                        }
                        else if (databasevalue == "ageratings")
                        {
                            Возрастной_рейтинг agerating = entity.Возрастной_рейтинг.FirstOrDefault(a => a.Код_возрастного_рейтинга == id);
                            entity.Возрастной_рейтинг.Remove(agerating);
                            entity.SaveChanges();
                            ShowAgeRating_Click(sender, e);
                        }
                        else if (databasevalue == "publishers")
                        {
                            Издатели publ = entity.Издатели.FirstOrDefault(a => a.Код_издателя == id);
                            entity.Издатели.Remove(publ);
                            entity.SaveChanges();
                            ShowPublisher_Click(sender, e);
                        }
                        else { MessageBox.Show("Ошибка в программных названиях таблиц"); break; }
                    }
                    else { MessageBox.Show("Эти данные удалять нельзя"); }
                }
            }
            else { MessageBox.Show("Эти данные удалять нельзя"); }
        }

        private void AddGame_Click(object sender, EventArgs e)
        {
            if (databasevalue == "developers")
            {
                DataGridViewSelectedRowCollection Datalist = Database.SelectedRows;
                AddGame game = new AddGame(Datalist);
                game.ShowDialog();
                ShowGames_Click(sender, e);
            }
            else MessageBox.Show("Выберите разработчика для добавления игры");
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

        private void Change_Click(object sender, EventArgs e)
        {
            if (databasevalue == "games" || databasevalue == "gameitems" || 
                databasevalue == "developers" || databasevalue == "traders"  )
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
                        else if (databasevalue == "developers")
                        {
                            ChangeDeveloper changeDev = new ChangeDeveloper(id);
                            changeDev.ShowDialog();
                            ShowDevelopers_Click(sender, e);
                        }
                        else if (databasevalue == "traders")
                        {
                            ChangeTrader changeTrader = new ChangeTrader(id);
                            changeTrader.ShowDialog();
                            ShowTraders_Click(sender, e);
                        }                      
                        else { MessageBox.Show("Ошибка в программных названиях таблиц");}
                    }
                    else { MessageBox.Show("Эти данные изменять нельзя"); }
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
                "Для выхода нажмите на кнопку выхода в меню авторизации.");
        }
    }
}