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

namespace Game_items_selling_forms.Change
{   
    public partial class ChangeDeveloper : Form
    {
        Game_items_tradingEnt entity = new Game_items_tradingEnt();
        int dev_id;
        public ChangeDeveloper(int id)
        {
            dev_id = id;
            InitializeComponent();
            Разработчики dev = entity.Разработчики.FirstOrDefault(a => a.Код_разработчика == id);
            DatetimeBox.Value = dev.Дата_основания;
            EmpCount.Value = dev.Кол_во_сотрудников;
            ShowDevelopers(dev);
        }
        private void ShowDevelopers(Разработчики dev)
        {
            Database.Rows.Clear();
            Database.Columns.Clear();

            Database.ColumnCount = 6;
            Database.ColumnHeadersVisible = true;

            Database.Columns[0].Name = "Код разработчика";
            Database.Columns[1].Name = "Название разработчика";
            Database.Columns[2].Name = "Дата основания";
            Database.Columns[3].Name = "Кол-во сотрудников";
            Database.Columns[4].Name = "Кол-во игр";

                Database.Rows.Add(
                    dev.Код_разработчика,
                    dev.Разработчик,
                    dev.Дата_основания,
                    dev.Кол_во_сотрудников,
                    dev.Игры.Count);            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeDeveloperButton_Click(object sender, EventArgs e)
        {
            Разработчики dev = entity.Разработчики.FirstOrDefault(a => a.Код_разработчика == dev_id);
            if (TitleBox.Text != "") { dev.Разработчик = TitleBox.Text; }
            if (DatetimeBox.Value < DateTime.Now)
            {
                dev.Дата_основания = DatetimeBox.Value;
            }
            if (EmpCount.Value > 0)
            {
                dev.Кол_во_сотрудников = (int)EmpCount.Value;
            }
            entity.SaveChanges();
            Close();
        }
    }
}
