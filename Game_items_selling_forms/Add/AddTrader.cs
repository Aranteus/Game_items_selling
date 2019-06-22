using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_items_selling_forms;

namespace Game_items_selling_forms.Admin
{
    public partial class AddTrader : Form
    {
        bool reg;
        public AddTrader(string regis)
        {
            InitializeComponent();
            CountriesBox.Items.AddRange(Queries.CountriesQuery());
            if (regis == "r") reg = true;
        }


        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddTraderMarket_Click(object sender, EventArgs e)
        {
            Game_items_tradingEnt entity = new Game_items_tradingEnt();

            if (TitleBox.Text != "" && DatetimeBox.Value != null && CountriesBox.Text != "")
            {
                if (DatetimeBox.Value <= DateTime.Now)
                {
                    Страны country = entity.Страны.FirstOrDefault(a => a.Страна == CountriesBox.Text);
                    Торговые_площадки trademarket = new Торговые_площадки
                    {
                        Дата_создания = DatetimeBox.Value,
                        Торговая_площадка = TitleBox.Text,
                        Страны = country
                    };

                    entity.Торговые_площадки.Add(trademarket);
                    entity.SaveChanges();
                    if (reg == true)
                    {
                        string login = trademarket.Код_торговой_площадки.ToString() + "_" + trademarket.Торговая_площадка.ToString();
                        string password = "trader";
                        MessageBox.Show($"Запомните следующие данные!\nВаш логин: {login}\nВаш пароль: {password}");
                    }
                    Close();
                }
                else MessageBox.Show("Неправильно введена дата");
            }
            else MessageBox.Show("Не все поля заполнены");
        }
    }
}
