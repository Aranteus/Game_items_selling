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
    public partial class ChangeTrader : Form
    {
        Game_items_tradingEnt entity = new Game_items_tradingEnt();
        int trader_id;
        public ChangeTrader(int id)
        {
            InitializeComponent();
            trader_id = id;
            Торговые_площадки trader = entity.Торговые_площадки.FirstOrDefault(a => a.Код_торговой_площадки == id);
            DatetimeBox.Value = trader.Дата_создания;
            CountriesBox.Items.AddRange(Queries.CountriesQuery());
            ShowTraders(trader);
        }
        private void ShowTraders(Торговые_площадки trade)
        {
            Database.Rows.Clear();
            Database.Columns.Clear();

            Database.ColumnCount = 6;
            Database.ColumnHeadersVisible = true;

            Database.Columns[0].Name = "Код торговой площадки";
            Database.Columns[1].Name = "Название торговой площадки";
            Database.Columns[2].Name = "Дата создания";
            Database.Columns[3].Name = "Страна";
            Database.Columns[4].Name = "Кол-во заказов";

                Database.Rows.Add(
                    trade.Код_торговой_площадки,
                    trade.Название,
                    trade.Дата_создания,
                    trade.Страны.Название,
                    trade.Чек.Count);
            Database.Rows.Add();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeTraderMarket_Click(object sender, EventArgs e)
        {
            Торговые_площадки trader = entity.Торговые_площадки.FirstOrDefault(a => a.Код_торговой_площадки == trader_id);
            if (TitleBox.Text != "") { trader.Название = TitleBox.Text; }
            if (CountriesBox.Text != "")
            {
                DataGridViewRow row = Database.SelectedRows[0];
                if (row != null)
                {
                    Страны count = entity.Страны.FirstOrDefault(a => a.Название == CountriesBox.Text);
                    trader.Страны = count;
                }
            }
            if (DatetimeBox.Value < DateTime.Now)
            {
                trader.Дата_создания = DatetimeBox.Value;
            }
            entity.SaveChanges();
            Close();
        }
    }
}
