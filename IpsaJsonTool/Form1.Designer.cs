namespace IpsaJsonTool
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importIpsaJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importMojangJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportIpsaJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMojangJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(212, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importIpsaJsonToolStripMenuItem,
            this.exportIpsaJsonToolStripMenuItem,
            this.importMojangJsonToolStripMenuItem,
            this.exportMojangJsonToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importIpsaJsonToolStripMenuItem
            // 
            this.importIpsaJsonToolStripMenuItem.Name = "importIpsaJsonToolStripMenuItem";
            this.importIpsaJsonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importIpsaJsonToolStripMenuItem.Text = "Import IpsaJson";
            // 
            // importMojangJsonToolStripMenuItem
            // 
            this.importMojangJsonToolStripMenuItem.Name = "importMojangJsonToolStripMenuItem";
            this.importMojangJsonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importMojangJsonToolStripMenuItem.Text = "Import MojangJson";
            // 
            // exportIpsaJsonToolStripMenuItem
            // 
            this.exportIpsaJsonToolStripMenuItem.Name = "exportIpsaJsonToolStripMenuItem";
            this.exportIpsaJsonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportIpsaJsonToolStripMenuItem.Text = "Export IpsaJson";
            // 
            // exportMojangJsonToolStripMenuItem
            // 
            this.exportMojangJsonToolStripMenuItem.Name = "exportMojangJsonToolStripMenuItem";
            this.exportMojangJsonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportMojangJsonToolStripMenuItem.Text = "Export MojangJson";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importIpsaJsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportIpsaJsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importMojangJsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportMojangJsonToolStripMenuItem;
    }
}

