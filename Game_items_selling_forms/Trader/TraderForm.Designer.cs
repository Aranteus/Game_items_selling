namespace Game_items_selling_forms.Trader
{
    partial class TraderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.СправкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ВыходВМенюАвторизацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Change = new System.Windows.Forms.Button();
            this.ImportExcel = new System.Windows.Forms.Button();
            this.DeleteAcc = new System.Windows.Forms.Button();
            this.Database = new System.Windows.Forms.DataGridView();
            this.ShowOrders = new System.Windows.Forms.Button();
            this.ShowGameItems = new System.Windows.Forms.Button();
            this.BuyGameItem = new System.Windows.Forms.Button();
            this.GameItemNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.TraderName = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Database)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameItemNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.СправкаToolStripMenuItem,
            this.ВыходВМенюАвторизацииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(609, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // СправкаToolStripMenuItem
            // 
            this.СправкаToolStripMenuItem.Name = "СправкаToolStripMenuItem";
            this.СправкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.СправкаToolStripMenuItem.Text = "Справка";
            this.СправкаToolStripMenuItem.Click += new System.EventHandler(this.СправкаToolStripMenuItem_Click);
            // 
            // ВыходВМенюАвторизацииToolStripMenuItem
            // 
            this.ВыходВМенюАвторизацииToolStripMenuItem.Name = "ВыходВМенюАвторизацииToolStripMenuItem";
            this.ВыходВМенюАвторизацииToolStripMenuItem.Size = new System.Drawing.Size(171, 20);
            this.ВыходВМенюАвторизацииToolStripMenuItem.Text = "Выйти в меню авторизации";
            this.ВыходВМенюАвторизацииToolStripMenuItem.Click += new System.EventHandler(this.ВыходВМенюАвторизацииToolStripMenuItem_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(12, 349);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(158, 53);
            this.Change.TabIndex = 27;
            this.Change.Text = "Редактировать торговую площадку";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // ImportExcel
            // 
            this.ImportExcel.Location = new System.Drawing.Point(470, 369);
            this.ImportExcel.Name = "ImportExcel";
            this.ImportExcel.Size = new System.Drawing.Size(127, 38);
            this.ImportExcel.TabIndex = 26;
            this.ImportExcel.Text = "Импортировать в Excel";
            this.ImportExcel.UseVisualStyleBackColor = true;
            this.ImportExcel.Click += new System.EventHandler(this.ImportExcel_Click);
            // 
            // DeleteAcc
            // 
            this.DeleteAcc.Location = new System.Drawing.Point(489, 30);
            this.DeleteAcc.Name = "DeleteAcc";
            this.DeleteAcc.Size = new System.Drawing.Size(108, 37);
            this.DeleteAcc.TabIndex = 25;
            this.DeleteAcc.Text = "Удалить аккаунт";
            this.DeleteAcc.UseVisualStyleBackColor = true;
            this.DeleteAcc.Click += new System.EventHandler(this.DeleteAcc_Click);
            // 
            // Database
            // 
            this.Database.AllowUserToAddRows = false;
            this.Database.AllowUserToDeleteRows = false;
            this.Database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Database.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Database.Location = new System.Drawing.Point(12, 30);
            this.Database.Name = "Database";
            this.Database.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Database.Size = new System.Drawing.Size(433, 304);
            this.Database.TabIndex = 24;
            // 
            // ShowOrders
            // 
            this.ShowOrders.Location = new System.Drawing.Point(470, 208);
            this.ShowOrders.Name = "ShowOrders";
            this.ShowOrders.Size = new System.Drawing.Size(127, 23);
            this.ShowOrders.TabIndex = 28;
            this.ShowOrders.Text = "Просмотр заказов";
            this.ShowOrders.UseVisualStyleBackColor = true;
            this.ShowOrders.Click += new System.EventHandler(this.ShowOrders_Click);
            // 
            // ShowGameItems
            // 
            this.ShowGameItems.Location = new System.Drawing.Point(470, 162);
            this.ShowGameItems.Name = "ShowGameItems";
            this.ShowGameItems.Size = new System.Drawing.Size(127, 40);
            this.ShowGameItems.TabIndex = 29;
            this.ShowGameItems.Text = "Просмотр каталога игровых предметов";
            this.ShowGameItems.UseVisualStyleBackColor = true;
            this.ShowGameItems.Click += new System.EventHandler(this.ShowGameItems_Click);
            // 
            // BuyGameItem
            // 
            this.BuyGameItem.Location = new System.Drawing.Point(335, 369);
            this.BuyGameItem.Name = "BuyGameItem";
            this.BuyGameItem.Size = new System.Drawing.Size(129, 38);
            this.BuyGameItem.TabIndex = 30;
            this.BuyGameItem.Text = "Купить игровой предмет";
            this.BuyGameItem.UseVisualStyleBackColor = true;
            this.BuyGameItem.Click += new System.EventHandler(this.BuyGameItem_Click);
            // 
            // GameItemNumber
            // 
            this.GameItemNumber.Location = new System.Drawing.Point(190, 369);
            this.GameItemNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.GameItemNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GameItemNumber.Name = "GameItemNumber";
            this.GameItemNumber.Size = new System.Drawing.Size(120, 20);
            this.GameItemNumber.TabIndex = 31;
            this.GameItemNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Введите кол-во предметов";
            // 
            // TraderName
            // 
            this.TraderName.Enabled = false;
            this.TraderName.Location = new System.Drawing.Point(458, 0);
            this.TraderName.Name = "TraderName";
            this.TraderName.Size = new System.Drawing.Size(139, 20);
            this.TraderName.TabIndex = 33;
            // 
            // TraderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 419);
            this.ControlBox = false;
            this.Controls.Add(this.TraderName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GameItemNumber);
            this.Controls.Add(this.BuyGameItem);
            this.Controls.Add(this.ShowGameItems);
            this.Controls.Add(this.ShowOrders);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.ImportExcel);
            this.Controls.Add(this.DeleteAcc);
            this.Controls.Add(this.Database);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TraderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trader";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Database)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameItemNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem СправкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ВыходВМенюАвторизацииToolStripMenuItem;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button ImportExcel;
        private System.Windows.Forms.Button DeleteAcc;
        private System.Windows.Forms.DataGridView Database;
        private System.Windows.Forms.Button ShowOrders;
        private System.Windows.Forms.Button ShowGameItems;
        private System.Windows.Forms.Button BuyGameItem;
        private System.Windows.Forms.NumericUpDown GameItemNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TraderName;
    }
}