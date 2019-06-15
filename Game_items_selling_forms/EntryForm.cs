using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_items_selling_forms
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        private void ВыходИзСистемыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void СправкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выберите способ авторизации в систему, нажав на соответствующие кнопки.\n" +
                "Введите логин и/или пароль аккаунта.\n У администратора пароль: admin.\n" +
                "У разработчика логин - название фирмы, например: 3_Test, пароль - developer.\n" +
                "У владельца логин - название фирмы, например: 3_Beta, пароль - trader.\n" +
                "Для выхода из системы нажмите на соответствующую клавишу сверху.");
        }

        private void AdminEntry_Click(object sender, EventArgs e)
        {
            AdminEntryForm adminEntry = new AdminEntryForm();
            Close();
            adminEntry.Show();
        }

        private void TraderEntry_Click(object sender, EventArgs e)
        {
            TraderEntryForm traderEntry = new TraderEntryForm();
            Close();
            traderEntry.Show();
        }

        private void CreatorEntry_Click(object sender, EventArgs e)
        {
            DeveloperEntryForm creatorEntry = new DeveloperEntryForm();
            Close();
            creatorEntry.Show();
        }
    }
}
