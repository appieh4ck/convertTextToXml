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
            this.lstXML = new System.Windows.Forms.ListBox();
            this.btnConverteer = new System.Windows.Forms.Button();
            this.ofdXML = new System.Windows.Forms.OpenFileDialog();
            this.grpFilesView = new System.Windows.Forms.GroupBox();
            this.sfdXML = new System.Windows.Forms.SaveFileDialog();
            this.sfdTextFile = new System.Windows.Forms.SaveFileDialog();
            this.btnXMLtoText = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpFilesView.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1087, 24);
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
            this.openTekstbestand,
            this.openXML});
            this.openTekstbestandToolStripMenuItem.Name = "openTekstbestandToolStripMenuItem";
            this.openTekstbestandToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openTekstbestandToolStripMenuItem.Text = "Open";
            this.openTekstbestandToolStripMenuItem.Click += new System.EventHandler(this.openTekstbestandToolStripMenuItem_Click);
            // 
            // openXML
            // 
            this.openXML.Name = "openXML";
            this.openXML.Size = new System.Drawing.Size(216, 22);
            this.openXML.Text = "Open XML";
            this.openXML.Click += new System.EventHandler(this.openXML_Click);
            // 
            // openTekstbestand
            // 
            this.openTekstbestand.Name = "openTekstbestand";
            this.openTekstbestand.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openTekstbestand.Size = new System.Drawing.Size(216, 22);
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
            this.slaTeksbestandOp.Size = new System.Drawing.Size(218, 22);
            this.slaTeksbestandOp.Text = "Sla teksbestand op";
            // 
            // slaXMLBestandOp
            // 
            this.slaXMLBestandOp.Name = "slaXMLBestandOp";
            this.slaXMLBestandOp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.slaXMLBestandOp.Size = new System.Drawing.Size(218, 22);
            this.slaXMLBestandOp.Text = "Sla XML bestand op";
            this.slaXMLBestandOp.Click += new System.EventHandler(this.slaXMLBestandOp_Click);
            // 
            // ofdTextFile
            // 
            this.ofdTextFile.FileName = "openFileDialog1";
            this.ofdTextFile.Filter = "Text files | *.txt";
            // 
            // lblAantalLijnenTekst
            // 
            this.lblAantalLijnenTekst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAantalLijnenTekst.AutoSize = true;
            this.lblAantalLijnenTekst.Location = new System.Drawing.Point(16, 383);
            this.lblAantalLijnenTekst.Name = "lblAantalLijnenTekst";
            this.lblAantalLijnenTekst.Size = new System.Drawing.Size(0, 13);
            this.lblAantalLijnenTekst.TabIndex = 2;
            // 
            // txtTextfile
            // 
            this.txtTextfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTextfile.Location = new System.Drawing.Point(16, 29);
            this.txtTextfile.Multiline = true;
            this.txtTextfile.Name = "txtTextfile";
            this.txtTextfile.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtTextfile.Size = new System.Drawing.Size(480, 345);
            this.txtTextfile.TabIndex = 3;
            this.txtTextfile.TextChanged += new System.EventHandler(this.txtTextfile_TextChanged);
            // 
            // lstXML
            // 
            this.lstXML.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstXML.FormattingEnabled = true;
            this.lstXML.HorizontalScrollbar = true;
            this.lstXML.Location = new System.Drawing.Point(502, 29);
            this.lstXML.Name = "lstXML";
            this.lstXML.Size = new System.Drawing.Size(490, 342);
            this.lstXML.TabIndex = 4;
            // 
            // btnConverteer
            // 
            this.btnConverteer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConverteer.Location = new System.Drawing.Point(138, 472);
            this.btnConverteer.Name = "btnConverteer";
            this.btnConverteer.Size = new System.Drawing.Size(183, 23);
            this.btnConverteer.TabIndex = 5;
            this.btnConverteer.Text = "Converteer van tekst naar XML";
            this.btnConverteer.UseVisualStyleBackColor = true;
            this.btnConverteer.Click += new System.EventHandler(this.btnConverteer_Click);
            // 
            // ofdXML
            // 
            this.ofdXML.Filter = "XML Bestanden | *.xml";
            // 
            // grpFilesView
            // 
            this.grpFilesView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFilesView.Controls.Add(this.txtTextfile);
            this.grpFilesView.Controls.Add(this.lstXML);
            this.grpFilesView.Controls.Add(this.lblAantalLijnenTekst);
            this.grpFilesView.Location = new System.Drawing.Point(15, 38);
            this.grpFilesView.Name = "grpFilesView";
            this.grpFilesView.Size = new System.Drawing.Size(1020, 416);
            this.grpFilesView.TabIndex = 6;
            this.grpFilesView.TabStop = false;
            // 
            // sfdXML
            // 
            this.sfdXML.Filter = "XML Bestanden | *.xml";
            // 
            // sfdTextFile
            // 
            this.sfdTextFile.Filter = "Tekstbestanden | *.txt";
            // 
            // btnXMLtoText
            // 
            this.btnXMLtoText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXMLtoText.Location = new System.Drawing.Point(701, 472);
            this.btnXMLtoText.Name = "btnXMLtoText";
            this.btnXMLtoText.Size = new System.Drawing.Size(183, 23);
            this.btnXMLtoText.TabIndex = 7;
            this.btnXMLtoText.Text = "Converteer van XML naar tekst";
            this.btnXMLtoText.UseVisualStyleBackColor = true;
            // 
            // frmConvertTxtToXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 522);
            this.Controls.Add(this.btnXMLtoText);
            this.Controls.Add(this.grpFilesView);
            this.Controls.Add(this.btnConverteer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmConvertTxtToXml";
            this.Text = "Converteer tekstbestand naar XML";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpFilesView.ResumeLayout(false);
            this.grpFilesView.PerformLayout();
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
        private System.Windows.Forms.ListBox lstXML;
        private System.Windows.Forms.Button btnConverteer;
        private System.Windows.Forms.OpenFileDialog ofdXML;
        private System.Windows.Forms.GroupBox grpFilesView;
        private System.Windows.Forms.SaveFileDialog sfdXML;
        private System.Windows.Forms.SaveFileDialog sfdTextFile;
        private System.Windows.Forms.Button btnXMLtoText;
    }
}

