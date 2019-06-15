using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_items_selling_forms.Admin;
using Game_items_selling_forms.Developer;

namespace Game_items_selling_forms
{
    public partial class DeveloperEntryForm : Form
    {
        Game_items_tradingEnt entity = new Game_items_tradingEnt();
        public DeveloperEntryForm()
        {
            InitializeComponent();
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
            AddDeveloper developer = new AddDeveloper(regis);
            developer.ShowDialog();
        }

        private void EntryButton_Click(object sender, EventArgs e)
        {
            if (Login.Text != "" && Password.Text == "developer" )
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
                            Разработчики dev = entity.Разработчики.FirstOrDefault(a => a.Код_разработчика == id && a.Название == name);
                            if (dev != null)
                            {
                                DeveloperForm devform = new DeveloperForm(dev);
                                Close();
                                devform.Show();
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
    }
}
