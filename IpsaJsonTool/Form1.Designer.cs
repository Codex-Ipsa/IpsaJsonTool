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
            this.gameBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importIpsaJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportIpsaJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importMojangJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMojangJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.assetsFileSizeBox = new System.Windows.Forms.NumericUpDown();
            this.assetsSizeBox = new System.Windows.Forms.NumericUpDown();
            this.defResYBox = new System.Windows.Forms.NumericUpDown();
            this.defResXBox = new System.Windows.Forms.NumericUpDown();
            this.javaBox = new System.Windows.Forms.NumericUpDown();
            this.sizeBox = new System.Windows.Forms.NumericUpDown();
            this.assetsVirtCheck = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.assetsUrlBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.assetsNameBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.classpathBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.joinServerCheck = new System.Windows.Forms.CheckBox();
            this.loggingBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdAftBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdBefBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.versionBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.libsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.supplementDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetsFileSizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsSizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defResYBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defResXBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.javaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libsDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplementDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gameBox
            // 
            this.gameBox.Location = new System.Drawing.Point(140, 6);
            this.gameBox.Name = "gameBox";
            this.gameBox.Size = new System.Drawing.Size(250, 20);
            this.gameBox.TabIndex = 0;
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
            this.importIpsaJsonToolStripMenuItem.Click += new System.EventHandler(this.importIpsaJsonToolStripMenuItem_Click);
            // 
            // exportIpsaJsonToolStripMenuItem
            // 
            this.exportIpsaJsonToolStripMenuItem.Name = "exportIpsaJsonToolStripMenuItem";
            this.exportIpsaJsonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportIpsaJsonToolStripMenuItem.Text = "Export IpsaJson";
            this.exportIpsaJsonToolStripMenuItem.Click += new System.EventHandler(this.exportIpsaJsonToolStripMenuItem_Click);
            // 
            // importMojangJsonToolStripMenuItem
            // 
            this.importMojangJsonToolStripMenuItem.Name = "importMojangJsonToolStripMenuItem";
            this.importMojangJsonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importMojangJsonToolStripMenuItem.Text = "Import MojangJson";
            this.importMojangJsonToolStripMenuItem.Click += new System.EventHandler(this.importMojangJsonToolStripMenuItem_Click);
            // 
            // exportMojangJsonToolStripMenuItem
            // 
            this.exportMojangJsonToolStripMenuItem.Name = "exportMojangJsonToolStripMenuItem";
            this.exportMojangJsonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportMojangJsonToolStripMenuItem.Text = "Export MojangJson";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 349);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.assetsFileSizeBox);
            this.tabPage1.Controls.Add(this.assetsSizeBox);
            this.tabPage1.Controls.Add(this.defResYBox);
            this.tabPage1.Controls.Add(this.defResXBox);
            this.tabPage1.Controls.Add(this.javaBox);
            this.tabPage1.Controls.Add(this.sizeBox);
            this.tabPage1.Controls.Add(this.assetsVirtCheck);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.assetsUrlBox);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.assetsNameBox);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.classpathBox);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.joinServerCheck);
            this.tabPage1.Controls.Add(this.loggingBox);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.cmdAftBox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cmdBefBox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.urlBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.versionBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.gameBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 323);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // assetsFileSizeBox
            // 
            this.assetsFileSizeBox.Location = new System.Drawing.Point(536, 85);
            this.assetsFileSizeBox.Name = "assetsFileSizeBox";
            this.assetsFileSizeBox.Size = new System.Drawing.Size(250, 20);
            this.assetsFileSizeBox.TabIndex = 41;
            // 
            // assetsSizeBox
            // 
            this.assetsSizeBox.Location = new System.Drawing.Point(536, 58);
            this.assetsSizeBox.Name = "assetsSizeBox";
            this.assetsSizeBox.Size = new System.Drawing.Size(250, 20);
            this.assetsSizeBox.TabIndex = 40;
            // 
            // defResYBox
            // 
            this.defResYBox.Location = new System.Drawing.Point(276, 188);
            this.defResYBox.Name = "defResYBox";
            this.defResYBox.Size = new System.Drawing.Size(114, 20);
            this.defResYBox.TabIndex = 39;
            // 
            // defResXBox
            // 
            this.defResXBox.Location = new System.Drawing.Point(140, 188);
            this.defResXBox.Name = "defResXBox";
            this.defResXBox.Size = new System.Drawing.Size(114, 20);
            this.defResXBox.TabIndex = 38;
            // 
            // javaBox
            // 
            this.javaBox.Location = new System.Drawing.Point(141, 110);
            this.javaBox.Name = "javaBox";
            this.javaBox.Size = new System.Drawing.Size(250, 20);
            this.javaBox.TabIndex = 37;
            // 
            // sizeBox
            // 
            this.sizeBox.Location = new System.Drawing.Point(140, 84);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(250, 20);
            this.sizeBox.TabIndex = 36;
            // 
            // assetsVirtCheck
            // 
            this.assetsVirtCheck.AutoSize = true;
            this.assetsVirtCheck.Location = new System.Drawing.Point(140, 243);
            this.assetsVirtCheck.Name = "assetsVirtCheck";
            this.assetsVirtCheck.Size = new System.Drawing.Size(15, 14);
            this.assetsVirtCheck.TabIndex = 35;
            this.assetsVirtCheck.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 243);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Virtual assets (deprecated)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(259, 191);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(12, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "x";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(397, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Assets file size";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(397, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Assets size";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(397, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Assets URL";
            // 
            // assetsUrlBox
            // 
            this.assetsUrlBox.Location = new System.Drawing.Point(536, 32);
            this.assetsUrlBox.Name = "assetsUrlBox";
            this.assetsUrlBox.Size = new System.Drawing.Size(250, 20);
            this.assetsUrlBox.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(397, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Assets name";
            // 
            // assetsNameBox
            // 
            this.assetsNameBox.Location = new System.Drawing.Point(536, 6);
            this.assetsNameBox.Name = "assetsNameBox";
            this.assetsNameBox.Size = new System.Drawing.Size(250, 20);
            this.assetsNameBox.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Classpath";
            // 
            // classpathBox
            // 
            this.classpathBox.Location = new System.Drawing.Point(140, 292);
            this.classpathBox.Name = "classpathBox";
            this.classpathBox.Size = new System.Drawing.Size(250, 20);
            this.classpathBox.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Log4j config URL";
            // 
            // joinServerCheck
            // 
            this.joinServerCheck.AutoSize = true;
            this.joinServerCheck.Location = new System.Drawing.Point(140, 217);
            this.joinServerCheck.Name = "joinServerCheck";
            this.joinServerCheck.Size = new System.Drawing.Size(15, 14);
            this.joinServerCheck.TabIndex = 19;
            this.joinServerCheck.UseVisualStyleBackColor = true;
            // 
            // loggingBox
            // 
            this.loggingBox.Location = new System.Drawing.Point(140, 266);
            this.loggingBox.Name = "loggingBox";
            this.loggingBox.Size = new System.Drawing.Size(250, 20);
            this.loggingBox.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Join server popup";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Default resolution";
            // 
            // cmdAftBox
            // 
            this.cmdAftBox.Location = new System.Drawing.Point(140, 162);
            this.cmdAftBox.Name = "cmdAftBox";
            this.cmdAftBox.Size = new System.Drawing.Size(250, 20);
            this.cmdAftBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "CmdAft (game)";
            // 
            // cmdBefBox
            // 
            this.cmdBefBox.Location = new System.Drawing.Point(140, 136);
            this.cmdBefBox.Name = "cmdBefBox";
            this.cmdBefBox.Size = new System.Drawing.Size(250, 20);
            this.cmdBefBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "CmdBef (jvm)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Minimal Java version";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Client Size";
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(140, 58);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(250, 20);
            this.urlBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Client URL";
            // 
            // versionBox
            // 
            this.versionBox.Location = new System.Drawing.Point(140, 32);
            this.versionBox.Name = "versionBox";
            this.versionBox.Size = new System.Drawing.Size(250, 20);
            this.versionBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Version";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.libsDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 323);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Libraries";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // libsDataGridView
            // 
            this.libsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.libsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.libsDataGridView.Name = "libsDataGridView";
            this.libsDataGridView.Size = new System.Drawing.Size(786, 317);
            this.libsDataGridView.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.supplementDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 323);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Supplement";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // supplementDataGridView
            // 
            this.supplementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplementDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplementDataGridView.Location = new System.Drawing.Point(0, 0);
            this.supplementDataGridView.Name = "supplementDataGridView";
            this.supplementDataGridView.Size = new System.Drawing.Size(792, 323);
            this.supplementDataGridView.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetsFileSizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsSizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defResYBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defResXBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.javaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.libsDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.supplementDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gameBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importIpsaJsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportIpsaJsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importMojangJsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportMojangJsonToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox versionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cmdAftBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cmdBefBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox assetsNameBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox classpathBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox joinServerCheck;
        private System.Windows.Forms.TextBox loggingBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox assetsUrlBox;
        private System.Windows.Forms.DataGridView libsDataGridView;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox assetsVirtCheck;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown sizeBox;
        private System.Windows.Forms.NumericUpDown javaBox;
        private System.Windows.Forms.NumericUpDown defResXBox;
        private System.Windows.Forms.NumericUpDown defResYBox;
        private System.Windows.Forms.DataGridView supplementDataGridView;
        private System.Windows.Forms.NumericUpDown assetsFileSizeBox;
        private System.Windows.Forms.NumericUpDown assetsSizeBox;
    }
}

