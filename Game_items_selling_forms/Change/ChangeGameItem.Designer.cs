namespace Game_items_selling_forms.Change
{
    partial class ChangeGameItem
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
            this.Back = new System.Windows.Forms.Button();
            this.ChangeGameItemButton = new System.Windows.Forms.Button();
            this.Database = new System.Windows.Forms.DataGridView();
            this.GameItemsNumber = new System.Windows.Forms.NumericUpDown();
            this.Price = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RareBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrencyBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GameItemTitleBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Database)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameItemsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 298);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(123, 23);
            this.Back.TabIndex = 40;
            this.Back.Text = "Вернуться назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ChangeGameItemButton
            // 
            this.ChangeGameItemButton.Location = new System.Drawing.Point(495, 273);
            this.ChangeGameItemButton.Name = "ChangeGameItemButton";
            this.ChangeGameItemButton.Size = new System.Drawing.Size(135, 48);
            this.ChangeGameItemButton.TabIndex = 39;
            this.ChangeGameItemButton.Text = "Изменить игровой предмет";
            this.ChangeGameItemButton.UseVisualStyleBackColor = true;
            this.ChangeGameItemButton.Click += new System.EventHandler(this.ChangeGameItemButton_Click);
            // 
            // Database
            // 
            this.Database.AllowUserToAddRows = false;
            this.Database.AllowUserToDeleteRows = false;
            this.Database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Database.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Database.Location = new System.Drawing.Point(9, 6);
            this.Database.Name = "Database";
            this.Database.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Database.Size = new System.Drawing.Size(621, 116);
            this.Database.TabIndex = 38;
            // 
            // GameItemsNumber
            // 
            this.GameItemsNumber.Location = new System.Drawing.Point(370, 235);
            this.GameItemsNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.GameItemsNumber.Name = "GameItemsNumber";
            this.GameItemsNumber.Size = new System.Drawing.Size(120, 20);
            this.GameItemsNumber.TabIndex = 64;
            this.GameItemsNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Price
            // 
            this.Price.DecimalPlaces = 2;
            this.Price.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Price.Location = new System.Drawing.Point(370, 183);
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
            this.Price.TabIndex = 63;
            this.Price.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Введите цену игрового предмета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Введите редкость игрового предмета";
            // 
            // RareBox
            // 
            this.RareBox.Location = new System.Drawing.Point(370, 209);
            this.RareBox.Name = "RareBox";
            this.RareBox.Size = new System.Drawing.Size(118, 20);
            this.RareBox.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Введите количество игровых предметов";
            // 
            // CurrencyBox
            // 
            this.CurrencyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrencyBox.DropDownWidth = 300;
            this.CurrencyBox.FormattingEnabled = true;
            this.CurrencyBox.Location = new System.Drawing.Point(370, 159);
            this.CurrencyBox.Name = "CurrencyBox";
            this.CurrencyBox.Size = new System.Drawing.Size(121, 21);
            this.CurrencyBox.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Введите название игрового предмета";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Выберите валюту игры";
            // 
            // GameItemTitleBox
            // 
            this.GameItemTitleBox.Location = new System.Drawing.Point(370, 133);
            this.GameItemTitleBox.Name = "GameItemTitleBox";
            this.GameItemTitleBox.Size = new System.Drawing.Size(118, 20);
            this.GameItemTitleBox.TabIndex = 55;
            // 
            // ChangeGameItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 333);
            this.ControlBox = false;
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
            this.Controls.Add(this.Back);
            this.Controls.Add(this.ChangeGameItemButton);
            this.Controls.Add(this.Database);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChangeGameItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Game Item";
            ((System.ComponentModel.ISupportInitialize)(this.Database)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameItemsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button ChangeGameItemButton;
        private System.Windows.Forms.DataGridView Database;
        private System.Windows.Forms.NumericUpDown GameItemsNumber;
        private System.Windows.Forms.NumericUpDown Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RareBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CurrencyBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GameItemTitleBox;
    }
}