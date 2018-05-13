namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.у1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.у2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.у3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.у4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.у5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.у1ToolStripMenuItem,
            this.у2ToolStripMenuItem,
            this.у3ToolStripMenuItem,
            this.у4ToolStripMenuItem,
            this.у5ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // у1ToolStripMenuItem
            // 
            this.у1ToolStripMenuItem.Name = "у1ToolStripMenuItem";
            this.у1ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.у1ToolStripMenuItem.Text = "Урок 1";
            this.у1ToolStripMenuItem.Click += new System.EventHandler(this.у1ToolStripMenuItem_Click_1);
            // 
            // у2ToolStripMenuItem
            // 
            this.у2ToolStripMenuItem.Name = "у2ToolStripMenuItem";
            this.у2ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.у2ToolStripMenuItem.Text = "Урок 2";
            this.у2ToolStripMenuItem.Click += new System.EventHandler(this.у2ToolStripMenuItem_Click_1);
            // 
            // у3ToolStripMenuItem
            // 
            this.у3ToolStripMenuItem.Name = "у3ToolStripMenuItem";
            this.у3ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.у3ToolStripMenuItem.Text = "Урок 3";
            this.у3ToolStripMenuItem.Click += new System.EventHandler(this.у3ToolStripMenuItem_Click);
            // 
            // у4ToolStripMenuItem
            // 
            this.у4ToolStripMenuItem.Name = "у4ToolStripMenuItem";
            this.у4ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.у4ToolStripMenuItem.Text = "Урок 4";
            this.у4ToolStripMenuItem.Click += new System.EventHandler(this.у4ToolStripMenuItem_Click);
            // 
            // у5ToolStripMenuItem
            // 
            this.у5ToolStripMenuItem.Name = "у5ToolStripMenuItem";
            this.у5ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.у5ToolStripMenuItem.Text = "Урок 5";
            this.у5ToolStripMenuItem.Click += new System.EventHandler(this.у5ToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 540);
            this.panel1.TabIndex = 1;
            this.panel1.Layout += new System.Windows.Forms.LayoutEventHandler(this.panel1_Layout);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._01_1;
            this.ClientSize = new System.Drawing.Size(787, 564);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem у1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem у2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem у3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem у4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem у5ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

