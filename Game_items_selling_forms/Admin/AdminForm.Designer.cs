namespace Game_items_selling_forms
{
    partial class AdminForm
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
            this.выйтиВМенюАвторизацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowOrders = new System.Windows.Forms.Button();
            this.ImportExcel = new System.Windows.Forms.Button();
            this.ShowGames = new System.Windows.Forms.Button();
            this.ShowGameItems = new System.Windows.Forms.Button();
            this.ShowDevelopers = new System.Windows.Forms.Button();
            this.ShowTraders = new System.Windows.Forms.Button();
            this.AddGame = new System.Windows.Forms.Button();
            this.AddGameItem = new System.Windows.Forms.Button();
            this.AddDeveloper = new System.Windows.Forms.Button();
            this.AddTraders = new System.Windows.Forms.Button();
            this.ShowCurrency = new System.Windows.Forms.Button();
            this.ShowAgeRating = new System.Windows.Forms.Button();
            this.ShowGenre = new System.Windows.Forms.Button();
            this.ShowPublisher = new System.Windows.Forms.Button();
            this.ShowPlatform = new System.Windows.Forms.Button();
            this.ShowCountry = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
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
            this.Database.Size = new System.Drawing.Size(413, 304);
            this.Database.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.СправкаToolStripMenuItem,
            this.выйтиВМенюАвторизацииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(709, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // СправкаToolStripMenuItem
            // 
            this.СправкаToolStripMenuItem.Name = "СправкаToolStripMenuItem";
            this.СправкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.СправкаToolStripMenuItem.Text = "Справка";
            this.СправкаToolStripMenuItem.Click += new System.EventHandler(this.СправкаToolStripMenuItem_Click);
            // 
            // выйтиВМенюАвторизацииToolStripMenuItem
            // 
            this.выйтиВМенюАвторизацииToolStripMenuItem.Name = "выйтиВМенюАвторизацииToolStripMenuItem";
            this.выйтиВМенюАвторизацииToolStripMenuItem.Size = new System.Drawing.Size(171, 20);
            this.выйтиВМенюАвторизацииToolStripMenuItem.Text = "Выйти в меню авторизации";
            this.выйтиВМенюАвторизацииToolStripMenuItem.Click += new System.EventHandler(this.ВыйтиВМенюАвторизацииToolStripMenuItem_Click);
            // 
            // ShowOrders
            // 
            this.ShowOrders.Location = new System.Drawing.Point(443, 27);
            this.ShowOrders.Name = "ShowOrders";
            this.ShowOrders.Size = new System.Drawing.Size(127, 23);
            this.ShowOrders.TabIndex = 2;
            this.ShowOrders.Text = "Просмотр заказов";
            this.ShowOrders.UseVisualStyleBackColor = true;
            this.ShowOrders.Click += new System.EventHandler(this.ShowOrders_Click);
            // 
            // ImportExcel
            // 
            this.ImportExcel.Location = new System.Drawing.Point(576, 394);
            this.ImportExcel.Name = "ImportExcel";
            this.ImportExcel.Size = new System.Drawing.Size(127, 38);
            this.ImportExcel.TabIndex = 3;
            this.ImportExcel.Text = "Импортировать в Excel";
            this.ImportExcel.UseVisualStyleBackColor = true;
            this.ImportExcel.Click += new System.EventHandler(this.ImportExcel_Click);
            // 
            // ShowGames
            // 
            this.ShowGames.Location = new System.Drawing.Point(443, 56);
            this.ShowGames.Name = "ShowGames";
            this.ShowGames.Size = new System.Drawing.Size(127, 23);
            this.ShowGames.TabIndex = 4;
            this.ShowGames.Text = "Просмотр игр";
            this.ShowGames.UseVisualStyleBackColor = true;
            this.ShowGames.Click += new System.EventHandler(this.ShowGames_Click);
            // 
            // ShowGameItems
            // 
            this.ShowGameItems.Location = new System.Drawing.Point(443, 85);
            this.ShowGameItems.Name = "ShowGameItems";
            this.ShowGameItems.Size = new System.Drawing.Size(127, 35);
            this.ShowGameItems.TabIndex = 5;
            this.ShowGameItems.Text = "Просмотр игровых предметов";
            this.ShowGameItems.UseVisualStyleBackColor = true;
            this.ShowGameItems.Click += new System.EventHandler(this.ShowGameItems_Click);
            // 
            // ShowDevelopers
            // 
            this.ShowDevelopers.Location = new System.Drawing.Point(443, 126);
            this.ShowDevelopers.Name = "ShowDevelopers";
            this.ShowDevelopers.Size = new System.Drawing.Size(127, 37);
            this.ShowDevelopers.TabIndex = 6;
            this.ShowDevelopers.Text = "Просмотр разработчиков";
            this.ShowDevelopers.UseVisualStyleBackColor = true;
            this.ShowDevelopers.Click += new System.EventHandler(this.ShowDevelopers_Click);
            // 
            // ShowTraders
            // 
            this.ShowTraders.Location = new System.Drawing.Point(443, 169);
            this.ShowTraders.Name = "ShowTraders";
            this.ShowTraders.Size = new System.Drawing.Size(127, 37);
            this.ShowTraders.TabIndex = 7;
            this.ShowTraders.Text = "Просмотр торговых площадок";
            this.ShowTraders.UseVisualStyleBackColor = true;
            this.ShowTraders.Click += new System.EventHandler(this.ShowTraders_Click);
            // 
            // AddGame
            // 
            this.AddGame.Location = new System.Drawing.Point(12, 337);
            this.AddGame.Name = "AddGame";
            this.AddGame.Size = new System.Drawing.Size(127, 37);
            this.AddGame.TabIndex = 8;
            this.AddGame.Text = "Добавить игру";
            this.AddGame.UseVisualStyleBackColor = true;
            this.AddGame.Click += new System.EventHandler(this.AddGame_Click);
            // 
            // AddGameItem
            // 
            this.AddGameItem.Location = new System.Drawing.Point(145, 337);
            this.AddGameItem.Name = "AddGameItem";
            this.AddGameItem.Size = new System.Drawing.Size(127, 37);
            this.AddGameItem.TabIndex = 9;
            this.AddGameItem.Text = "Добавить игровой предмет";
            this.AddGameItem.UseVisualStyleBackColor = true;
            this.AddGameItem.Click += new System.EventHandler(this.AddGameItem_Click);
            // 
            // AddDeveloper
            // 
            this.AddDeveloper.Location = new System.Drawing.Point(278, 337);
            this.AddDeveloper.Name = "AddDeveloper";
            this.AddDeveloper.Size = new System.Drawing.Size(127, 37);
            this.AddDeveloper.TabIndex = 10;
            this.AddDeveloper.Text = "Добавить разработчика";
            this.AddDeveloper.UseVisualStyleBackColor = true;
            this.AddDeveloper.Click += new System.EventHandler(this.AddDeveloper_Click);
            // 
            // AddTraders
            // 
            this.AddTraders.Location = new System.Drawing.Point(411, 337);
            this.AddTraders.Name = "AddTraders";
            this.AddTraders.Size = new System.Drawing.Size(127, 37);
            this.AddTraders.TabIndex = 11;
            this.AddTraders.Text = "Добавить торговую площадку";
            this.AddTraders.UseVisualStyleBackColor = true;
            this.AddTraders.Click += new System.EventHandler(this.AddTraders_Click);
            // 
            // ShowCurrency
            // 
            this.ShowCurrency.Location = new System.Drawing.Point(576, 27);
            this.ShowCurrency.Name = "ShowCurrency";
            this.ShowCurrency.Size = new System.Drawing.Size(127, 23);
            this.ShowCurrency.TabIndex = 12;
            this.ShowCurrency.Text = "Просмотр валют";
            this.ShowCurrency.UseVisualStyleBackColor = true;
            this.ShowCurrency.Click += new System.EventHandler(this.ShowCurrency_Click);
            // 
            // ShowAgeRating
            // 
            this.ShowAgeRating.Location = new System.Drawing.Point(576, 56);
            this.ShowAgeRating.Name = "ShowAgeRating";
            this.ShowAgeRating.Size = new System.Drawing.Size(127, 67);
            this.ShowAgeRating.TabIndex = 13;
            this.ShowAgeRating.Text = "Просмотр возрастных рейтингов";
            this.ShowAgeRating.UseVisualStyleBackColor = true;
            this.ShowAgeRating.Click += new System.EventHandler(this.ShowAgeRating_Click);
            // 
            // ShowGenre
            // 
            this.ShowGenre.Location = new System.Drawing.Point(576, 129);
            this.ShowGenre.Name = "ShowGenre";
            this.ShowGenre.Size = new System.Drawing.Size(127, 23);
            this.ShowGenre.TabIndex = 14;
            this.ShowGenre.Text = "Просмотр жанров";
            this.ShowGenre.UseVisualStyleBackColor = true;
            this.ShowGenre.Click += new System.EventHandler(this.ShowGenre_Click);
            // 
            // ShowPublisher
            // 
            this.ShowPublisher.Location = new System.Drawing.Point(576, 158);
            this.ShowPublisher.Name = "ShowPublisher";
            this.ShowPublisher.Size = new System.Drawing.Size(127, 23);
            this.ShowPublisher.TabIndex = 15;
            this.ShowPublisher.Text = "Просмотр издателей";
            this.ShowPublisher.UseVisualStyleBackColor = true;
            this.ShowPublisher.Click += new System.EventHandler(this.ShowPublisher_Click);
            // 
            // ShowPlatform
            // 
            this.ShowPlatform.Location = new System.Drawing.Point(576, 187);
            this.ShowPlatform.Name = "ShowPlatform";
            this.ShowPlatform.Size = new System.Drawing.Size(127, 23);
            this.ShowPlatform.TabIndex = 16;
            this.ShowPlatform.Text = "Просмотр платформ";
            this.ShowPlatform.UseVisualStyleBackColor = true;
            this.ShowPlatform.Click += new System.EventHandler(this.ShowPlatform_Click);
            // 
            // ShowCountry
            // 
            this.ShowCountry.Location = new System.Drawing.Point(576, 216);
            this.ShowCountry.Name = "ShowCountry";
            this.ShowCountry.Size = new System.Drawing.Size(127, 23);
            this.ShowCountry.TabIndex = 17;
            this.ShowCountry.Text = "Просмотр стран";
            this.ShowCountry.UseVisualStyleBackColor = true;
            this.ShowCountry.Click += new System.EventHandler(this.ShowCountry_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(12, 380);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(393, 23);
            this.Change.TabIndex = 18;
            this.Change.Text = "Редактировать";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(12, 409);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(393, 23);
            this.Delete.TabIndex = 19;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 438);
            this.ControlBox = false;
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.ShowCountry);
            this.Controls.Add(this.ShowPlatform);
            this.Controls.Add(this.ShowPublisher);
            this.Controls.Add(this.ShowGenre);
            this.Controls.Add(this.ShowAgeRating);
            this.Controls.Add(this.ShowCurrency);
            this.Controls.Add(this.AddTraders);
            this.Controls.Add(this.AddDeveloper);
            this.Controls.Add(this.AddGameItem);
            this.Controls.Add(this.AddGame);
            this.Controls.Add(this.ShowTraders);
            this.Controls.Add(this.ShowDevelopers);
            this.Controls.Add(this.ShowGameItems);
            this.Controls.Add(this.ShowGames);
            this.Controls.Add(this.ImportExcel);
            this.Controls.Add(this.ShowOrders);
            this.Controls.Add(this.Database);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
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
        private System.Windows.Forms.ToolStripMenuItem выйтиВМенюАвторизацииToolStripMenuItem;
        private System.Windows.Forms.Button ShowOrders;
        private System.Windows.Forms.Button ImportExcel;
        private System.Windows.Forms.Button ShowGames;
        private System.Windows.Forms.Button ShowGameItems;
        private System.Windows.Forms.Button ShowDevelopers;
        private System.Windows.Forms.Button ShowTraders;
        private System.Windows.Forms.Button AddGame;
        private System.Windows.Forms.Button AddGameItem;
        private System.Windows.Forms.Button AddDeveloper;
        private System.Windows.Forms.Button AddTraders;
        private System.Windows.Forms.Button ShowCurrency;
        private System.Windows.Forms.Button ShowAgeRating;
        private System.Windows.Forms.Button ShowGenre;
        private System.Windows.Forms.Button ShowPublisher;
        private System.Windows.Forms.Button ShowPlatform;
        private System.Windows.Forms.Button ShowCountry;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Delete;
    }
}