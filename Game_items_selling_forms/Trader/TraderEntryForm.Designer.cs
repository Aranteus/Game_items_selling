namespace Game_items_selling_forms
{
    partial class TraderEntryForm
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
            this.EntryButton = new System.Windows.Forms.Button();
            this.PreviousForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.RegisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EntryButton
            // 
            this.EntryButton.Location = new System.Drawing.Point(90, 119);
            this.EntryButton.Name = "EntryButton";
            this.EntryButton.Size = new System.Drawing.Size(100, 23);
            this.EntryButton.TabIndex = 7;
            this.EntryButton.Text = "Войти в систему";
            this.EntryButton.UseVisualStyleBackColor = true;
            this.EntryButton.Click += new System.EventHandler(this.EntryButton_Click);
            // 
            // PreviousForm
            // 
            this.PreviousForm.Location = new System.Drawing.Point(50, 196);
            this.PreviousForm.Name = "PreviousForm";
            this.PreviousForm.Size = new System.Drawing.Size(178, 23);
            this.PreviousForm.TabIndex = 6;
            this.PreviousForm.Text = "Вернуться в меню авторизации";
            this.PreviousForm.UseVisualStyleBackColor = true;
            this.PreviousForm.Click += new System.EventHandler(this.PreviousForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введите логин и пароль владельца фирмы";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(90, 93);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 8;
            this.Password.Text = "trader";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(90, 56);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 20);
            this.Login.TabIndex = 10;
            this.Login.Text = "Логин";
            // 
            // RegisButton
            // 
            this.RegisButton.Location = new System.Drawing.Point(73, 167);
            this.RegisButton.Name = "RegisButton";
            this.RegisButton.Size = new System.Drawing.Size(129, 23);
            this.RegisButton.TabIndex = 11;
            this.RegisButton.Text = "Зарегистрироваться";
            this.RegisButton.UseVisualStyleBackColor = true;
            this.RegisButton.Click += new System.EventHandler(this.RegisButton_Click);
            // 
            // TraderEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(284, 231);
            this.ControlBox = false;
            this.Controls.Add(this.RegisButton);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.EntryButton);
            this.Controls.Add(this.PreviousForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TraderEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trader Entry Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EntryButton;
        private System.Windows.Forms.Button PreviousForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Button RegisButton;
    }
}