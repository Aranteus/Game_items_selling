using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_items_selling_forms.Admin
{
    public partial class AddGameItem : Form
    {
        Game_items_tradingEnt entity = new Game_items_tradingEnt();
        DataGridViewRow row;
        public AddGameItem(DataGridViewSelectedRowCollection Datalist)
        {
            InitializeComponent();
            CurrencyBox.Items.AddRange(Queries.CurrenciesQuery());
            row = Datalist[0];
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddGameItemButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(row.Cells[0].Value);
            Игры game = entity.Игры.FirstOrDefault(a => a.Код_игры == id);

            if (GameItemTitleBox.Text != "" && CurrencyBox.Text != ""
                && Price.Value > 0 && RareBox.Text != "" && GameItemsNumber.Value > 0)
            {
                Валюты curr = entity.Валюты.FirstOrDefault(a => a.Название == CurrencyBox.Text);

                Предметы_из_игр gameitem = new Предметы_из_игр
                {
                    Название = GameItemTitleBox.Text,
                    Валюты = curr,
                    Цена = Price.Value,
                    Редкость = RareBox.Text,
                    Количество = (int)GameItemsNumber.Value
                };
                game.Предметы_из_игр.Add(gameitem);
                entity.SaveChanges();
                Close();
            }
            else MessageBox.Show("Не все поля заполнены");
        }
    }
}
