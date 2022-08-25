namespace Impor_Export_WMS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connBtn = new System.Windows.Forms.Button();
            this.tablistDb = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.datagridView = new System.Windows.Forms.DataGridView();
            this.getdbBtn = new System.Windows.Forms.Button();
            this.cleardbBtn = new System.Windows.Forms.Button();
            this.U_artRb = new System.Windows.Forms.RadioButton();
            this.D_artRB = new System.Windows.Forms.RadioButton();
            this.A_artRB = new System.Windows.Forms.RadioButton();
            this.Art_OP_Gb = new System.Windows.Forms.GroupBox();
            this.art_artTb = new System.Windows.Forms.TextBox();
            this.des_artTb = new System.Windows.Forms.TextBox();
            this.sot_artTb = new System.Windows.Forms.TextBox();
            this.umi_artTb = new System.Windows.Forms.TextBox();
            this.senddbBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ServerLbl = new System.Windows.Forms.Label();
            this.dbLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridView)).BeginInit();
            this.Art_OP_Gb.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // connBtn
            // 
            this.connBtn.Location = new System.Drawing.Point(12, 28);
            this.connBtn.Name = "connBtn";
            this.connBtn.Size = new System.Drawing.Size(196, 43);
            this.connBtn.TabIndex = 0;
            this.connBtn.Text = "Connect to Server";
            this.connBtn.UseVisualStyleBackColor = true;
            this.connBtn.Click += new System.EventHandler(this.connBtn_Click);
            // 
            // tablistDb
            // 
            this.tablistDb.FormattingEnabled = true;
            this.tablistDb.Location = new System.Drawing.Point(22, 166);
            this.tablistDb.Name = "tablistDb";
            this.tablistDb.Size = new System.Drawing.Size(225, 21);
            this.tablistDb.TabIndex = 1;
            this.tablistDb.SelectedIndexChanged += new System.EventHandler(this.tablistDb_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(225, 96);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // datagridView
            // 
            this.datagridView.AllowUserToAddRows = false;
            this.datagridView.AllowUserToDeleteRows = false;
            this.datagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridView.Location = new System.Drawing.Point(6, 52);
            this.datagridView.Name = "datagridView";
            this.datagridView.ReadOnly = true;
            this.datagridView.Size = new System.Drawing.Size(654, 150);
            this.datagridView.TabIndex = 3;
            // 
            // getdbBtn
            // 
            this.getdbBtn.Location = new System.Drawing.Point(6, 23);
            this.getdbBtn.Name = "getdbBtn";
            this.getdbBtn.Size = new System.Drawing.Size(105, 23);
            this.getdbBtn.TabIndex = 4;
            this.getdbBtn.Text = "Retrieve Data";
            this.getdbBtn.UseVisualStyleBackColor = true;
            this.getdbBtn.Click += new System.EventHandler(this.getdbBtn_Click);
            // 
            // cleardbBtn
            // 
            this.cleardbBtn.Location = new System.Drawing.Point(117, 23);
            this.cleardbBtn.Name = "cleardbBtn";
            this.cleardbBtn.Size = new System.Drawing.Size(105, 23);
            this.cleardbBtn.TabIndex = 5;
            this.cleardbBtn.Text = "Clear Data";
            this.cleardbBtn.UseVisualStyleBackColor = true;
            this.cleardbBtn.Click += new System.EventHandler(this.cleardbBtn_Click);
            // 
            // U_artRb
            // 
            this.U_artRb.AutoSize = true;
            this.U_artRb.Location = new System.Drawing.Point(11, 19);
            this.U_artRb.Name = "U_artRb";
            this.U_artRb.Size = new System.Drawing.Size(60, 17);
            this.U_artRb.TabIndex = 6;
            this.U_artRb.TabStop = true;
            this.U_artRb.Text = "Update";
            this.U_artRb.UseVisualStyleBackColor = true;
            this.U_artRb.CheckedChanged += new System.EventHandler(this.U_artRb_CheckedChanged);
            // 
            // D_artRB
            // 
            this.D_artRB.AutoSize = true;
            this.D_artRB.Location = new System.Drawing.Point(86, 19);
            this.D_artRB.Name = "D_artRB";
            this.D_artRB.Size = new System.Drawing.Size(56, 17);
            this.D_artRB.TabIndex = 7;
            this.D_artRB.TabStop = true;
            this.D_artRB.Text = "Delete";
            this.D_artRB.UseVisualStyleBackColor = true;
            // 
            // A_artRB
            // 
            this.A_artRB.AutoSize = true;
            this.A_artRB.Location = new System.Drawing.Point(158, 19);
            this.A_artRB.Name = "A_artRB";
            this.A_artRB.Size = new System.Drawing.Size(44, 17);
            this.A_artRB.TabIndex = 8;
            this.A_artRB.TabStop = true;
            this.A_artRB.Text = "Add";
            this.A_artRB.UseVisualStyleBackColor = true;
            // 
            // Art_OP_Gb
            // 
            this.Art_OP_Gb.Controls.Add(this.A_artRB);
            this.Art_OP_Gb.Controls.Add(this.U_artRb);
            this.Art_OP_Gb.Controls.Add(this.D_artRB);
            this.Art_OP_Gb.Location = new System.Drawing.Point(24, 27);
            this.Art_OP_Gb.Name = "Art_OP_Gb";
            this.Art_OP_Gb.Size = new System.Drawing.Size(220, 45);
            this.Art_OP_Gb.TabIndex = 9;
            this.Art_OP_Gb.TabStop = false;
            this.Art_OP_Gb.Text = "Operation";
            // 
            // art_artTb
            // 
            this.art_artTb.Location = new System.Drawing.Point(24, 88);
            this.art_artTb.Name = "art_artTb";
            this.art_artTb.Size = new System.Drawing.Size(220, 20);
            this.art_artTb.TabIndex = 10;
            // 
            // des_artTb
            // 
            this.des_artTb.Location = new System.Drawing.Point(24, 125);
            this.des_artTb.Name = "des_artTb";
            this.des_artTb.Size = new System.Drawing.Size(220, 20);
            this.des_artTb.TabIndex = 11;
            // 
            // sot_artTb
            // 
            this.sot_artTb.Location = new System.Drawing.Point(24, 160);
            this.sot_artTb.Name = "sot_artTb";
            this.sot_artTb.Size = new System.Drawing.Size(92, 20);
            this.sot_artTb.TabIndex = 12;
            // 
            // umi_artTb
            // 
            this.umi_artTb.Location = new System.Drawing.Point(149, 160);
            this.umi_artTb.Name = "umi_artTb";
            this.umi_artTb.Size = new System.Drawing.Size(95, 20);
            this.umi_artTb.TabIndex = 13;
            // 
            // senddbBtn
            // 
            this.senddbBtn.Location = new System.Drawing.Point(24, 196);
            this.senddbBtn.Name = "senddbBtn";
            this.senddbBtn.Size = new System.Drawing.Size(75, 23);
            this.senddbBtn.TabIndex = 14;
            this.senddbBtn.Text = "Sent Data";
            this.senddbBtn.UseVisualStyleBackColor = true;
            this.senddbBtn.Click += new System.EventHandler(this.senddbBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(690, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportDataToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportDataToolStripMenuItem
            // 
            this.exportDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVToolStripMenuItem});
            this.exportDataToolStripMenuItem.Name = "exportDataToolStripMenuItem";
            this.exportDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportDataToolStripMenuItem.Text = "Export Data";
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.cSVToolStripMenuItem.Text = "CSV";
            this.cSVToolStripMenuItem.Click += new System.EventHandler(this.cSVToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Table List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Select Table";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tablistDb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 201);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table Configuration";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Art_OP_Gb);
            this.groupBox2.Controls.Add(this.art_artTb);
            this.groupBox2.Controls.Add(this.senddbBtn);
            this.groupBox2.Controls.Add(this.des_artTb);
            this.groupBox2.Controls.Add(this.umi_artTb);
            this.groupBox2.Controls.Add(this.sot_artTb);
            this.groupBox2.Location = new System.Drawing.Point(407, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 226);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "InputI tems (IMP_ARTICOLI)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.datagridView);
            this.groupBox3.Controls.Add(this.getdbBtn);
            this.groupBox3.Controls.Add(this.cleardbBtn);
            this.groupBox3.Location = new System.Drawing.Point(12, 336);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(666, 205);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Retrieve Data from Server";
            // 
            // ServerLbl
            // 
            this.ServerLbl.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerLbl.Location = new System.Drawing.Point(228, 31);
            this.ServerLbl.Name = "ServerLbl";
            this.ServerLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ServerLbl.Size = new System.Drawing.Size(268, 23);
            this.ServerLbl.TabIndex = 21;
            this.ServerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dbLbl
            // 
            this.dbLbl.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dbLbl.Location = new System.Drawing.Point(228, 47);
            this.dbLbl.Name = "dbLbl";
            this.dbLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dbLbl.Size = new System.Drawing.Size(264, 18);
            this.dbLbl.TabIndex = 22;
            this.dbLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 553);
            this.Controls.Add(this.dbLbl);
            this.Controls.Add(this.ServerLbl);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.connBtn);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMPORT-EXPORT WMS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridView)).EndInit();
            this.Art_OP_Gb.ResumeLayout(false);
            this.Art_OP_Gb.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connBtn;
        private System.Windows.Forms.ComboBox tablistDb;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView datagridView;
        private System.Windows.Forms.Button getdbBtn;
        private System.Windows.Forms.Button cleardbBtn;
        private System.Windows.Forms.RadioButton U_artRb;
        private System.Windows.Forms.RadioButton D_artRB;
        private System.Windows.Forms.RadioButton A_artRB;
        private System.Windows.Forms.GroupBox Art_OP_Gb;
        private System.Windows.Forms.TextBox art_artTb;
        private System.Windows.Forms.TextBox des_artTb;
        private System.Windows.Forms.TextBox sot_artTb;
        private System.Windows.Forms.TextBox umi_artTb;
        private System.Windows.Forms.Button senddbBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label ServerLbl;
        private System.Windows.Forms.Label dbLbl;
    }
}

