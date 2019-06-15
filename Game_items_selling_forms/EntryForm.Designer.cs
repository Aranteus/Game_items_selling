namespace Game_items_selling_forms
{
    partial class EntryForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreatorEntry = new System.Windows.Forms.Button();
            this.TraderEntry = new System.Windows.Forms.Button();
            this.AdminEntry = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.СправкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ВыходИзСистемыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreatorEntry
            // 
            this.CreatorEntry.Location = new System.Drawing.Point(75, 65);
            this.CreatorEntry.Name = "CreatorEntry";
            this.CreatorEntry.Size = new System.Drawing.Size(120, 48);
            this.CreatorEntry.TabIndex = 2;
            this.CreatorEntry.Text = "Войти в систему за разработчика";
            this.CreatorEntry.UseVisualStyleBackColor = true;
            this.CreatorEntry.Click += new System.EventHandler(this.CreatorEntry_Click);
            // 
            // TraderEntry
            // 
            this.TraderEntry.Location = new System.Drawing.Point(75, 119);
            this.TraderEntry.Name = "TraderEntry";
            this.TraderEntry.Size = new System.Drawing.Size(120, 52);
            this.TraderEntry.TabIndex = 3;
            this.TraderEntry.Text = "Войти в систему за владельца фирмы";
            this.TraderEntry.UseVisualStyleBackColor = true;
            this.TraderEntry.Click += new System.EventHandler(this.TraderEntry_Click);
            // 
            // AdminEntry
            // 
            this.AdminEntry.BackColor = System.Drawing.SystemColors.Control;
            this.AdminEntry.Location = new System.Drawing.Point(75, 177);
            this.AdminEntry.Name = "AdminEntry";
            this.AdminEntry.Size = new System.Drawing.Size(120, 53);
            this.AdminEntry.TabIndex = 4;
            this.AdminEntry.Text = "Войти в систему за администратора";
            this.AdminEntry.UseVisualStyleBackColor = false;
            this.AdminEntry.Click += new System.EventHandler(this.AdminEntry_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.СправкаToolStripMenuItem,
            this.ВыходИзСистемыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(274, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // СправкаToolStripMenuItem
            // 
            this.СправкаToolStripMenuItem.Name = "СправкаToolStripMenuItem";
            this.СправкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.СправкаToolStripMenuItem.Text = "Справка";
            this.СправкаToolStripMenuItem.Click += new System.EventHandler(this.СправкаToolStripMenuItem_Click);
            // 
            // ВыходИзСистемыToolStripMenuItem
            // 
            this.ВыходИзСистемыToolStripMenuItem.Name = "ВыходИзСистемыToolStripMenuItem";
            this.ВыходИзСистемыToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.ВыходИзСистемыToolStripMenuItem.Text = "Выход из системы";
            this.ВыходИзСистемыToolStripMenuItem.Click += new System.EventHandler(this.ВыходИзСистемыToolStripMenuItem_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(274, 261);
            this.ControlBox = false;
            this.Controls.Add(this.AdminEntry);
            this.Controls.Add(this.TraderEntry);
            this.Controls.Add(this.CreatorEntry);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entry Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreatorEntry;
        private System.Windows.Forms.Button TraderEntry;
        private System.Windows.Forms.Button AdminEntry;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem СправкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ВыходИзСистемыToolStripMenuItem;
    }
}

