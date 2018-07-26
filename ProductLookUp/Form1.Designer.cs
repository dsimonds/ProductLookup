namespace ProductLookUp
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.Barcode = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.oRLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wPBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fTLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kLOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kYTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Location = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 31);
            this.textBox1.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(401, 70);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(143, 39);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Barcode
            // 
            this.Barcode.AutoSize = true;
            this.Barcode.Location = new System.Drawing.Point(58, 77);
            this.Barcode.Name = "Barcode";
            this.Barcode.Size = new System.Drawing.Size(98, 25);
            this.Barcode.TabIndex = 2;
            this.Barcode.Text = "Barcode:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oRLToolStripMenuItem,
            this.wPBToolStripMenuItem,
            this.fTLToolStripMenuItem,
            this.mIAToolStripMenuItem,
            this.kLOToolStripMenuItem,
            this.kYTToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 220);
            // 
            // oRLToolStripMenuItem
            // 
            this.oRLToolStripMenuItem.Name = "oRLToolStripMenuItem";
            this.oRLToolStripMenuItem.Size = new System.Drawing.Size(139, 36);
            this.oRLToolStripMenuItem.Text = "ORL";
            // 
            // wPBToolStripMenuItem
            // 
            this.wPBToolStripMenuItem.Name = "wPBToolStripMenuItem";
            this.wPBToolStripMenuItem.Size = new System.Drawing.Size(139, 36);
            this.wPBToolStripMenuItem.Text = "WPB";
            // 
            // fTLToolStripMenuItem
            // 
            this.fTLToolStripMenuItem.Name = "fTLToolStripMenuItem";
            this.fTLToolStripMenuItem.Size = new System.Drawing.Size(139, 36);
            this.fTLToolStripMenuItem.Text = "FTL";
            // 
            // mIAToolStripMenuItem
            // 
            this.mIAToolStripMenuItem.Name = "mIAToolStripMenuItem";
            this.mIAToolStripMenuItem.Size = new System.Drawing.Size(139, 36);
            this.mIAToolStripMenuItem.Text = "MIA";
            // 
            // kLOToolStripMenuItem
            // 
            this.kLOToolStripMenuItem.Name = "kLOToolStripMenuItem";
            this.kLOToolStripMenuItem.Size = new System.Drawing.Size(139, 36);
            this.kLOToolStripMenuItem.Text = "KLO";
            // 
            // kYTToolStripMenuItem
            // 
            this.kYTToolStripMenuItem.Name = "kYTToolStripMenuItem";
            this.kYTToolStripMenuItem.Size = new System.Drawing.Size(139, 36);
            this.kYTToolStripMenuItem.Text = "KYT";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ORL",
            "WPB",
            "FTL",
            "MIA",
            "KYT",
            "KLO"});
            this.comboBox1.Location = new System.Drawing.Point(177, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 4;
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Location = new System.Drawing.Point(58, 156);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(100, 25);
            this.Location.TabIndex = 5;
            this.Location.Text = "Location:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 257);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Barcode);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Lookup";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label Barcode;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oRLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wPBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fTLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kLOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kYTToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Location;
    }
}

