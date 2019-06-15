namespace Game_items_selling_forms.Admin
{
    partial class AddGameItem
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
            this.CurrencyBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GameItemTitleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RareBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.NumericUpDown();
            this.GameItemsNumber = new System.Windows.Forms.NumericUpDown();
            this.AddGameItemButton = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameItemsNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrencyBox
            // 
            this.CurrencyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrencyBox.DropDownWidth = 300;
            this.CurrencyBox.FormattingEnabled = true;
            this.CurrencyBox.Location = new System.Drawing.Point(232, 38);
            this.CurrencyBox.Name = "CurrencyBox";
            this.CurrencyBox.Size = new System.Drawing.Size(121, 21);
            this.CurrencyBox.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Введите название игрового предмета";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Выберите валюту игры";
            // 
            // GameItemTitleBox
            // 
            this.GameItemTitleBox.Location = new System.Drawing.Point(232, 12);
            this.GameItemTitleBox.Name = "GameItemTitleBox";
            this.GameItemTitleBox.Size = new System.Drawing.Size(118, 20);
            this.GameItemTitleBox.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Введите количество игровых предметов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Введите редкость игрового предмета";
            // 
            // RareBox
            // 
            this.RareBox.Location = new System.Drawing.Point(232, 88);
            this.RareBox.Name = "RareBox";
            this.RareBox.Size = new System.Drawing.Size(118, 20);
            this.RareBox.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Введите цену игрового предмета";
            // 
            // Price
            // 
            this.Price.DecimalPlaces = 2;
            this.Price.Location = new System.Drawing.Point(232, 62);
            this.Price.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.Price.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(120, 20);
            this.Price.TabIndex = 53;
            this.Price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GameItemsNumber
            // 
            this.GameItemsNumber.Location = new System.Drawing.Point(232, 114);
            this.GameItemsNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.GameItemsNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GameItemsNumber.Name = "GameItemsNumber";
            this.GameItemsNumber.Size = new System.Drawing.Size(120, 20);
            this.GameItemsNumber.TabIndex = 54;
            this.GameItemsNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddGameItemButton
            // 
            this.AddGameItemButton.Location = new System.Drawing.Point(218, 165);
            this.AddGameItemButton.Name = "AddGameItemButton";
            this.AddGameItemButton.Size = new System.Drawing.Size(135, 44);
            this.AddGameItemButton.TabIndex = 65;
            this.AddGameItemButton.Text = "Добавить игровой предмет";
            this.AddGameItemButton.UseVisualStyleBackColor = true;
            this.AddGameItemButton.Click += new System.EventHandler(this.AddGameItemButton_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 186);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(123, 23);
            this.Back.TabIndex = 64;
            this.Back.Text = "Вернуться назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AddGameItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 225);
            this.ControlBox = false;
            this.Controls.Add(this.AddGameItemButton);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.GameItemsNumber);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RareBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrencyBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GameItemTitleBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddGameItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Game Item";
            ((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameItemsNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CurrencyBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GameItemTitleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RareBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Price;
        private System.Windows.Forms.NumericUpDown GameItemsNumber;
        private System.Windows.Forms.Button AddGameItemButton;
        private System.Windows.Forms.Button Back;
    }
}