using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_items_selling_forms.Trader;
using Game_items_selling_forms.Admin;

namespace Game_items_selling_forms
{
    public partial class TraderEntryForm : Form
    {
        Game_items_tradingEnt entity = new Game_items_tradingEnt();
        public TraderEntryForm()
        {
            InitializeComponent();
        }

        private void EntryButton_Click(object sender, EventArgs e)
        {
            if (Login.Text != "" && Password.Text == "trader")
            {
                string login = Login.Text;
                if (login.Contains("_") == true)
                {
                    string[] mas = login.Split('_');
                    if (mas.Length == 2)
                    {
                        if (Int32.TryParse(mas[0], out int id) == true)
                        {
                            string name = mas[1];
                            Торговые_площадки trader = entity.Торговые_площадки.FirstOrDefault(a => a.Код_торговой_площадки == id && a.Название == name);
                            if (trader != null)
                            {
                                TraderForm traderform = new TraderForm(trader);
                                Close();
                                traderform.Show();
                            }
                            else MessageBox.Show("Неправильный логин");
                        }
                        else MessageBox.Show("Неправильный логин");
                    }
                    else MessageBox.Show("Неправильный логин");
                }
                else MessageBox.Show("Неправильный логин");
            }
            else MessageBox.Show("Неправильный логин или пароль");       
        }

        private void PreviousForm_Click(object sender, EventArgs e)
        {
            EntryForm Entry = new EntryForm();
            Close();
            Entry.Show();
        }

        private void RegisButton_Click(object sender, EventArgs e)
        {
            string regis = "r";
            AddTrader trader = new AddTrader(regis);
            trader.ShowDialog();
        }
    }
}