namespace MenuApp
{
    partial class frmLayout
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bleuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blancheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationsToolStripMenuItem,
            this.pageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.operationsToolStripMenuItem.Text = "&Operations";
            this.operationsToolStripMenuItem.Click += new System.EventHandler(this.operationsToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // pageToolStripMenuItem
            // 
            this.pageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verteToolStripMenuItem,
            this.noireToolStripMenuItem,
            this.bleuToolStripMenuItem,
            this.blancheToolStripMenuItem});
            this.pageToolStripMenuItem.Name = "pageToolStripMenuItem";
            this.pageToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.pageToolStripMenuItem.Text = "&Page";
            // 
            // verteToolStripMenuItem
            // 
            this.verteToolStripMenuItem.Name = "verteToolStripMenuItem";
            this.verteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verteToolStripMenuItem.Text = "&Verte";
            this.verteToolStripMenuItem.Click += new System.EventHandler(this.verteToolStripMenuItem_Click);
            // 
            // noireToolStripMenuItem
            // 
            this.noireToolStripMenuItem.Name = "noireToolStripMenuItem";
            this.noireToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noireToolStripMenuItem.Text = "&Noire";
            this.noireToolStripMenuItem.Click += new System.EventHandler(this.noireToolStripMenuItem_Click);
            // 
            // bleuToolStripMenuItem
            // 
            this.bleuToolStripMenuItem.Name = "bleuToolStripMenuItem";
            this.bleuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bleuToolStripMenuItem.Text = "&Bleu";
            this.bleuToolStripMenuItem.Click += new System.EventHandler(this.bleuToolStripMenuItem_Click);
            // 
            // blancheToolStripMenuItem
            // 
            this.blancheToolStripMenuItem.Name = "blancheToolStripMenuItem";
            this.blancheToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blancheToolStripMenuItem.Text = "&Blanche";
            this.blancheToolStripMenuItem.Click += new System.EventHandler(this.blancheToolStripMenuItem_Click);
            // 
            // frmLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLayout";
            this.Text = "Training UX Design";
            this.Load += new System.EventHandler(this.frmLayout_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bleuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blancheToolStripMenuItem;
    }
}