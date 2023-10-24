namespace convertTextToXml
{
    partial class frmConvertTxtToXml
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
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTekstbestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openXML = new System.Windows.Forms.ToolStripMenuItem();
            this.openTekstbestand = new System.Windows.Forms.ToolStripMenuItem();
            this.slaXMLOpToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.slaTeksbestandOp = new System.Windows.Forms.ToolStripMenuItem();
            this.slaXMLBestandOp = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdTextFile = new System.Windows.Forms.OpenFileDialog();
            this.lblAantalLijnenTekst = new System.Windows.Forms.Label();
            this.txtTextfile = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1120, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTekstbestandToolStripMenuItem,
            this.slaXMLOpToolStrip});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bestandToolStripMenuItem.Text = "Bestand";
            // 
            // openTekstbestandToolStripMenuItem
            // 
            this.openTekstbestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openXML,
            this.openTekstbestand});
            this.openTekstbestandToolStripMenuItem.Name = "openTekstbestandToolStripMenuItem";
            this.openTekstbestandToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openTekstbestandToolStripMenuItem.Text = "Open";
            this.openTekstbestandToolStripMenuItem.Click += new System.EventHandler(this.openTekstbestandToolStripMenuItem_Click);
            // 
            // openXML
            // 
            this.openXML.Name = "openXML";
            this.openXML.Size = new System.Drawing.Size(180, 22);
            this.openXML.Text = "Open XML";
            // 
            // openTekstbestand
            // 
            this.openTekstbestand.Name = "openTekstbestand";
            this.openTekstbestand.Size = new System.Drawing.Size(180, 22);
            this.openTekstbestand.Text = "Open tekstbestand";
            this.openTekstbestand.Click += new System.EventHandler(this.openTekstbestand_Click);
            // 
            // slaXMLOpToolStrip
            // 
            this.slaXMLOpToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slaTeksbestandOp,
            this.slaXMLBestandOp});
            this.slaXMLOpToolStrip.Name = "slaXMLOpToolStrip";
            this.slaXMLOpToolStrip.Size = new System.Drawing.Size(180, 22);
            this.slaXMLOpToolStrip.Text = "Opslaan";
            this.slaXMLOpToolStrip.Click += new System.EventHandler(this.slaXMLOpToolStripMenuItem_Click);
            // 
            // slaTeksbestandOp
            // 
            this.slaTeksbestandOp.Name = "slaTeksbestandOp";
            this.slaTeksbestandOp.Size = new System.Drawing.Size(180, 22);
            this.slaTeksbestandOp.Text = "Sla teksbestand op";
            // 
            // slaXMLBestandOp
            // 
            this.slaXMLBestandOp.Name = "slaXMLBestandOp";
            this.slaXMLBestandOp.Size = new System.Drawing.Size(180, 22);
            this.slaXMLBestandOp.Text = "Sla XML bestand op";
            // 
            // ofdTextFile
            // 
            this.ofdTextFile.FileName = "openFileDialog1";
            this.ofdTextFile.Filter = "Text files | *.txt";
            // 
            // lblAantalLijnenTekst
            // 
            this.lblAantalLijnenTekst.AutoSize = true;
            this.lblAantalLijnenTekst.Location = new System.Drawing.Point(12, 361);
            this.lblAantalLijnenTekst.Name = "lblAantalLijnenTekst";
            this.lblAantalLijnenTekst.Size = new System.Drawing.Size(0, 13);
            this.lblAantalLijnenTekst.TabIndex = 2;
            // 
            // txtTextfile
            // 
            this.txtTextfile.Location = new System.Drawing.Point(12, 27);
            this.txtTextfile.Multiline = true;
            this.txtTextfile.Name = "txtTextfile";
            this.txtTextfile.Size = new System.Drawing.Size(662, 331);
            this.txtTextfile.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(713, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(395, 329);
            this.listBox1.TabIndex = 4;
            // 
            // frmConvertTxtToXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 479);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtTextfile);
            this.Controls.Add(this.lblAantalLijnenTekst);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmConvertTxtToXml";
            this.Text = "Converteer tekstbestand naar XML";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTekstbestandToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdTextFile;
        private System.Windows.Forms.Label lblAantalLijnenTekst;
        private System.Windows.Forms.TextBox txtTextfile;
        private System.Windows.Forms.ToolStripMenuItem slaXMLOpToolStrip;
        private System.Windows.Forms.ToolStripMenuItem openXML;
        private System.Windows.Forms.ToolStripMenuItem openTekstbestand;
        private System.Windows.Forms.ToolStripMenuItem slaTeksbestandOp;
        private System.Windows.Forms.ToolStripMenuItem slaXMLBestandOp;
        private System.Windows.Forms.ListBox listBox1;
    }
}

