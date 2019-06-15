namespace Game_items_selling_forms.Change
{
    partial class ChangeDeveloper
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
            this.EmpCount = new System.Windows.Forms.NumericUpDown();
            this.DatetimeBox = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.ChangeDeveloperButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Database)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpCount)).BeginInit();
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
            this.Database.TabIndex = 26;
            // 
            // EmpCount
            // 
            this.EmpCount.Location = new System.Drawing.Point(381, 201);
            this.EmpCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.EmpCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EmpCount.Name = "EmpCount";
            this.EmpCount.Size = new System.Drawing.Size(120, 20);
            this.EmpCount.TabIndex = 32;
            this.EmpCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DatetimeBox
            // 
            this.DatetimeBox.Location = new System.Drawing.Point(381, 175);
            this.DatetimeBox.Name = "DatetimeBox";
            this.DatetimeBox.Size = new System.Drawing.Size(118, 20);
            this.DatetimeBox.TabIndex = 31;
            this.DatetimeBox.Value = new System.DateTime(2019, 3, 5, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Введите дату создания компании";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Введите количество сотрудников";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Введите название компании - разработчика";
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(381, 149);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(118, 20);
            this.TitleBox.TabIndex = 27;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 269);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(123, 23);
            this.Back.TabIndex = 34;
            this.Back.Text = "Вернуться назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ChangeDeveloperButton
            // 
            this.ChangeDeveloperButton.Location = new System.Drawing.Point(498, 244);
            this.ChangeDeveloperButton.Name = "ChangeDeveloperButton";
            this.ChangeDeveloperButton.Size = new System.Drawing.Size(135, 48);
            this.ChangeDeveloperButton.TabIndex = 33;
            this.ChangeDeveloperButton.Text = "Изменить разработчика\r\n";
            this.ChangeDeveloperButton.UseVisualStyleBackColor = true;
            this.ChangeDeveloperButton.Click += new System.EventHandler(this.ChangeDeveloperButton_Click);
            // 
            // ChangeDeveloper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 304);
            this.ControlBox = false;
            this.Controls.Add(this.Back);
            this.Controls.Add(this.ChangeDeveloperButton);
            this.Controls.Add(this.EmpCount);
            this.Controls.Add(this.DatetimeBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.Database);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChangeDeveloper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Developer";
            ((System.ComponentModel.ISupportInitialize)(this.Database)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Database;
        private System.Windows.Forms.NumericUpDown EmpCount;
        private System.Windows.Forms.DateTimePicker DatetimeBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button ChangeDeveloperButton;
    }
}