using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_items_selling_forms.Change
{
    public partial class ChangeGameItem : Form
    {
        Game_items_tradingEnt entity = new Game_items_tradingEnt();
        int gameitem_id;
        public ChangeGameItem(int id)
        {
            InitializeComponent();
            Предметы_из_игр gameitem = entity.Предметы_из_игр.FirstOrDefault(a=> a.Код_предмета == id);
            gameitem_id = gameitem.Код_предмета;
            Price.Value = gameitem.Цена;
            GameItemsNumber.Value = gameitem.Количество;
            CurrencyBox.Items.AddRange(Queries.CurrenciesQuery());
            ShowGameItems(gameitem);
        }
        private void ShowGameItems(Предметы_из_игр item)
        {
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

                Database.Rows.Add(
                    item.Код_предмета,
                    item.Название,
                    item.Редкость,
                    item.Валюты.Название,
                    item.Цена,
                    item.Количество,
                    item.Игры.Название,
                    item.Чек.Count);
            Database.Rows.Add();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeGameItemButton_Click(object sender, EventArgs e)
        {
            Предметы_из_игр gameitem = entity.Предметы_из_игр.FirstOrDefault(a => a.Код_предмета == gameitem_id);
            if (GameItemTitleBox.Text != "") { gameitem.Название = GameItemTitleBox.Text; }
            if (CurrencyBox.Text != "")
            {
                DataGridViewRow row = Database.SelectedRows[0];
                if (row != null)
                {
                    Валюты curr = entity.Валюты.FirstOrDefault(a => a.Название == CurrencyBox.Text);
                    gameitem.Валюты = curr;
                }
            }
            if (Price.Value > 0) { gameitem.Цена = Price.Value; }
            if (RareBox.Text != "") { gameitem.Редкость = RareBox.Text; }
            if (GameItemsNumber.Value > 0) { gameitem.Количество = (int)GameItemsNumber.Value; }
            entity.SaveChanges();
            Close();
        }
    }
}
