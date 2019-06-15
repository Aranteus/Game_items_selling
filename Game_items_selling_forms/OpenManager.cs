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
    /// <summary>
    /// Главная форма, отвечающая только за работу приложения
    /// </summary>
    public partial class OpenManager : Form 
    {
        public OpenManager openManager;
        public OpenManager()
        {   
            openManager = this;

            //Полное скрытие формы
            WindowState = FormWindowState.Minimized;  
            ShowInTaskbar = false;
            Visible = false; 

            InitializeComponent();

            //Открытик 1-ой формы
            Form entryForm = new EntryForm();
            entryForm.ShowDialog();
        }
    }
}
