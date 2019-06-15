namespace Game_items_selling_forms
{
    partial class AdminEntryForm
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
            this.PreviousForm = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EntryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PreviousForm
            // 
            this.PreviousForm.Location = new System.Drawing.Point(55, 123);
            this.PreviousForm.Name = "PreviousForm";
            this.PreviousForm.Size = new System.Drawing.Size(123, 23);
            this.PreviousForm.TabIndex = 0;
            this.PreviousForm.Text = "Вернуться в меню авторизации";
            this.PreviousForm.UseVisualStyleBackColor = true;
            this.PreviousForm.Click += new System.EventHandler(this.PreviousForm_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(66, 54);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 1;
            this.Password.Text = "admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите пароль администратора";
            // 
            // EntryButton
            // 
            this.EntryButton.Location = new System.Drawing.Point(66, 94);
            this.EntryButton.Name = "EntryButton";
            this.EntryButton.Size = new System.Drawing.Size(100, 23);
            this.EntryButton.TabIndex = 3;
            this.EntryButton.Text = "Войти в систему";
            this.EntryButton.UseVisualStyleBackColor = true;
            this.EntryButton.Click += new System.EventHandler(this.EntryButton_Click);
            // 
            // AdminEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 158);
            this.ControlBox = false;
            this.Controls.Add(this.EntryButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.PreviousForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Entry Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PreviousForm;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EntryButton;
    }
}