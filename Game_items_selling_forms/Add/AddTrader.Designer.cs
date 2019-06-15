namespace Game_items_selling_forms.Admin
{
    partial class AddTrader
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
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CountriesBox = new System.Windows.Forms.ComboBox();
            this.AddTraderMarket = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.DatetimeBox = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(277, 25);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(100, 20);
            this.TitleBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите название торговой площадки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выберите страну";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите дату создания\r\n";
            // 
            // CountriesBox
            // 
            this.CountriesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountriesBox.DropDownWidth = 300;
            this.CountriesBox.FormattingEnabled = true;
            this.CountriesBox.Location = new System.Drawing.Point(256, 77);
            this.CountriesBox.Name = "CountriesBox";
            this.CountriesBox.Size = new System.Drawing.Size(121, 21);
            this.CountriesBox.TabIndex = 6;
            // 
            // AddTraderMarket
            // 
            this.AddTraderMarket.Location = new System.Drawing.Point(108, 127);
            this.AddTraderMarket.Name = "AddTraderMarket";
            this.AddTraderMarket.Size = new System.Drawing.Size(199, 23);
            this.AddTraderMarket.TabIndex = 7;
            this.AddTraderMarket.Text = "Добавить торговую площадку";
            this.AddTraderMarket.UseVisualStyleBackColor = true;
            this.AddTraderMarket.Click += new System.EventHandler(this.AddTraderMarket_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(133, 156);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(142, 23);
            this.Back.TabIndex = 8;
            this.Back.Text = "Вернуться назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // DatetimeBox
            // 
            this.DatetimeBox.Location = new System.Drawing.Point(256, 51);
            this.DatetimeBox.Name = "DatetimeBox";
            this.DatetimeBox.Size = new System.Drawing.Size(121, 20);
            this.DatetimeBox.TabIndex = 9;
            this.DatetimeBox.Value = new System.DateTime(1998, 12, 31, 0, 0, 0, 0);
            // 
            // AddTrader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 191);
            this.ControlBox = false;
            this.Controls.Add(this.DatetimeBox);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.AddTraderMarket);
            this.Controls.Add(this.CountriesBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddTrader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Trader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CountriesBox;
        private System.Windows.Forms.Button AddTraderMarket;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DateTimePicker DatetimeBox;
    }
}