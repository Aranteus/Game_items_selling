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
    public partial class AdminEntryForm : Form
    {
        public AdminEntryForm()
        {
            InitializeComponent();
        }

        private void PreviousForm_Click(object sender, EventArgs e)
        {
            EntryForm Entry = new EntryForm();
            Close();
            Entry.Show();
        }

        private void EntryButton_Click(object sender, EventArgs e)
        {
            if (Password.Text == "admin")
            {
                AdminForm admin = new AdminForm();
                Close();
                admin.Show();
            }
            else MessageBox.Show("Неправильный пароль");
        }
    }
}
