namespace Game_items_selling_forms.Developer
{
    partial class DeveloperForm
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
            this.Database = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.СправкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ВыходВМенюАвторизацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteAcc = new System.Windows.Forms.Button();
            this.ShowOrders = new System.Windows.Forms.Button();
            this.ShowGameItems = new System.Windows.Forms.Button();
            this.ShowGames = new System.Windows.Forms.Button();
            this.ImportExcel = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.AddGameItem = new System.Windows.Forms.Button();
            this.AddGame = new System.Windows.Forms.Button();
            this.ChangeAcc = new System.Windows.Forms.Button();
            this.DevName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Database)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Database
            // 
            this.Database.AllowUserToAddRows = false;
            this.Database.AllowUserToDeleteRows = false;
            this.Database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Database.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Database.Location = new System.Drawing.Point(12, 27);
            this.Database.Name = "Database";
            this.Database.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Database.Size = new System.Drawing.Size(433, 304);
            this.Database.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.СправкаToolStripMenuItem,
            this.ВыходВМенюАвторизацииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(603, 24);
            this.menuStrip1.TabIndex = 2;
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
            // DeleteAcc
            // 
            this.DeleteAcc.Location = new System.Drawing.Point(483, 27);
            this.DeleteAcc.Name = "DeleteAcc";
            this.DeleteAcc.Size = new System.Drawing.Size(108, 37);
            this.DeleteAcc.TabIndex = 3;
            this.DeleteAcc.Text = "Удалить аккаунт";
            this.DeleteAcc.UseVisualStyleBackColor = true;
            this.DeleteAcc.Click += new System.EventHandler(this.DeleteAcc_Click);
            // 
            // ShowOrders
            // 
            this.ShowOrders.Location = new System.Drawing.Point(464, 227);
            this.ShowOrders.Name = "ShowOrders";
            this.ShowOrders.Size = new System.Drawing.Size(127, 23);
            this.ShowOrders.TabIndex = 4;
            this.ShowOrders.Text = "Просмотр заказов";
            this.ShowOrders.UseVisualStyleBackColor = true;
            this.ShowOrders.Click += new System.EventHandler(this.ShowOrders_Click);
            // 
            // ShowGameItems
            // 
            this.ShowGameItems.Location = new System.Drawing.Point(464, 285);
            this.ShowGameItems.Name = "ShowGameItems";
            this.ShowGameItems.Size = new System.Drawing.Size(127, 35);
            this.ShowGameItems.TabIndex = 7;
            this.ShowGameItems.Text = "Мои игровые предметы";
            this.ShowGameItems.UseVisualStyleBackColor = true;
            this.ShowGameItems.Click += new System.EventHandler(this.ShowGameItems_Click);
            // 
            // ShowGames
            // 
            this.ShowGames.Location = new System.Drawing.Point(464, 256);
            this.ShowGames.Name = "ShowGames";
            this.ShowGames.Size = new System.Drawing.Size(127, 23);
            this.ShowGames.TabIndex = 6;
            this.ShowGames.Text = "Мои игры";
            this.ShowGames.UseVisualStyleBackColor = true;
            this.ShowGames.Click += new System.EventHandler(this.ShowGames_Click);
            // 
            // ImportExcel
            // 
            this.ImportExcel.Location = new System.Drawing.Point(464, 389);
            this.ImportExcel.Name = "ImportExcel";
            this.ImportExcel.Size = new System.Drawing.Size(127, 38);
            this.ImportExcel.TabIndex = 8;
            this.ImportExcel.Text = "Импортировать в Excel";
            this.ImportExcel.UseVisualStyleBackColor = true;
            this.ImportExcel.Click += new System.EventHandler(this.ImportExcel_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(12, 409);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(393, 23);
            this.Delete.TabIndex = 23;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(12, 380);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(393, 23);
            this.Change.TabIndex = 22;
            this.Change.Text = "Редактировать";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // AddGameItem
            // 
            this.AddGameItem.Location = new System.Drawing.Point(145, 337);
            this.AddGameItem.Name = "AddGameItem";
            this.AddGameItem.Size = new System.Drawing.Size(127, 37);
            this.AddGameItem.TabIndex = 21;
            this.AddGameItem.Text = "Добавить игровой предмет";
            this.AddGameItem.UseVisualStyleBackColor = true;
            this.AddGameItem.Click += new System.EventHandler(this.AddGameItem_Click);
            // 
            // AddGame
            // 
            this.AddGame.Location = new System.Drawing.Point(12, 337);
            this.AddGame.Name = "AddGame";
            this.AddGame.Size = new System.Drawing.Size(127, 37);
            this.AddGame.TabIndex = 20;
            this.AddGame.Text = "Добавить игру";
            this.AddGame.UseVisualStyleBackColor = true;
            this.AddGame.Click += new System.EventHandler(this.AddGame_Click);
            // 
            // ChangeAcc
            // 
            this.ChangeAcc.Location = new System.Drawing.Point(483, 113);
            this.ChangeAcc.Name = "ChangeAcc";
            this.ChangeAcc.Size = new System.Drawing.Size(108, 43);
            this.ChangeAcc.TabIndex = 24;
            this.ChangeAcc.Text = "Редактировать аккаунт";
            this.ChangeAcc.UseVisualStyleBackColor = true;
            this.ChangeAcc.Click += new System.EventHandler(this.ChangeAcc_Click);
            // 
            // DevName
            // 
            this.DevName.Enabled = false;
            this.DevName.Location = new System.Drawing.Point(452, 1);
            this.DevName.Name = "DevName";
            this.DevName.Size = new System.Drawing.Size(139, 20);
            this.DevName.TabIndex = 25;
            // 
            // DeveloperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 439);
            this.ControlBox = false;
            this.Controls.Add(this.DevName);
            this.Controls.Add(this.ChangeAcc);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.AddGameItem);
            this.Controls.Add(this.AddGame);
            this.Controls.Add(this.ImportExcel);
            this.Controls.Add(this.ShowGameItems);
            this.Controls.Add(this.ShowGames);
            this.Controls.Add(this.ShowOrders);
            this.Controls.Add(this.DeleteAcc);
            this.Controls.Add(this.Database);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DeveloperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Developer";
            ((System.ComponentModel.ISupportInitialize)(this.Database)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Database;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem СправкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ВыходВМенюАвторизацииToolStripMenuItem;
        private System.Windows.Forms.Button DeleteAcc;
        private System.Windows.Forms.Button ShowOrders;
        private System.Windows.Forms.Button ShowGameItems;
        private System.Windows.Forms.Button ShowGames;
        private System.Windows.Forms.Button ImportExcel;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button AddGameItem;
        private System.Windows.Forms.Button AddGame;
        private System.Windows.Forms.Button ChangeAcc;
        private System.Windows.Forms.TextBox DevName;
    }
}