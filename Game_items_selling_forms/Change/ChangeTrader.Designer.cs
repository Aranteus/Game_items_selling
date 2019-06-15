namespace Game_items_selling_forms.Change
{
    partial class ChangeTrader
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
            this.DatetimeBox = new System.Windows.Forms.DateTimePicker();
            this.Back = new System.Windows.Forms.Button();
            this.ChangeTraderMarket = new System.Windows.Forms.Button();
            this.CountriesBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Database)).BeginInit();
            this.SuspendLayout();
            // 
            // Database
            // 
            this.Database.AllowUserToAddRows = false;
            this.Database.AllowUserToDeleteRows = false;
            this.Database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Database.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Database.Location = new System.Drawing.Point(12, 12);
            this.Database.Name = "Database";
            this.Database.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Database.Size = new System.Drawing.Size(621, 116);
            this.Database.TabIndex = 25;
            // 
            // DatetimeBox
            // 
            this.DatetimeBox.Location = new System.Drawing.Point(390, 184);
            this.DatetimeBox.Name = "DatetimeBox";
            this.DatetimeBox.Size = new System.Drawing.Size(121, 20);
            this.DatetimeBox.TabIndex = 33;
            this.DatetimeBox.Value = new System.DateTime(1998, 12, 31, 0, 0, 0, 0);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 258);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(142, 23);
            this.Back.TabIndex = 32;
            this.Back.Text = "Вернуться назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ChangeTraderMarket
            // 
            this.ChangeTraderMarket.Location = new System.Drawing.Point(434, 258);
            this.ChangeTraderMarket.Name = "ChangeTraderMarket";
            this.ChangeTraderMarket.Size = new System.Drawing.Size(199, 23);
            this.ChangeTraderMarket.TabIndex = 31;
            this.ChangeTraderMarket.Text = "Изменить торговую площадку";
            this.ChangeTraderMarket.UseVisualStyleBackColor = true;
            this.ChangeTraderMarket.Click += new System.EventHandler(this.ChangeTraderMarket_Click);
            // 
            // CountriesBox
            // 
            this.CountriesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountriesBox.DropDownWidth = 300;
            this.CountriesBox.FormattingEnabled = true;
            this.CountriesBox.Location = new System.Drawing.Point(390, 210);
            this.CountriesBox.Name = "CountriesBox";
            this.CountriesBox.Size = new System.Drawing.Size(121, 21);
            this.CountriesBox.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Введите дату создания\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Выберите страну";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Введите название торговой площадки";
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(390, 158);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(121, 20);
            this.TitleBox.TabIndex = 26;
            // 
            // ChangeTrader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 304);
            this.ControlBox = false;
            this.Controls.Add(this.DatetimeBox);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.ChangeTraderMarket);
            this.Controls.Add(this.CountriesBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.Database);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChangeTrader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Trader";
            ((System.ComponentModel.ISupportInitialize)(this.Database)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Database;
        private System.Windows.Forms.DateTimePicker DatetimeBox;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button ChangeTraderMarket;
        private System.Windows.Forms.ComboBox CountriesBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleBox;
    }
}