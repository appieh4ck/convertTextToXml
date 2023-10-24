using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace convertTextToXml
{
    public partial class frmConvertTxtToXml : Form
    {
        public frmConvertTxtToXml()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openTekstbestandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnConverteer.Enabled = false;
            
        }

        private void slaXMLOpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void SlaTekstbestandToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void openTekstbestand_Click(object sender, EventArgs e)
        {
            if (ofdTextFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(ofdTextFile.FileName))
                {
                    string line;
                    // Read and display lines from the file until the end of  
                    // the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        txtTextfile.AppendText(line);
                        txtTextfile.AppendText(Environment.NewLine);
                    }
                }
                if (txtTextfile.Lines.Length == 24)
                {
                    if (XMLVariables.XMLFileName == "")
                    {
                        lblAantalLijnenTekst.Text = "Aantal lijnen is correct, maar je moet nog een XML bestand inladen!";
                    }
                    else
                    {
                        lblAantalLijnenTekst.Text = "Aantal lijnen is correct, conversie kan beginnen!";
                        btnConverteer.Enabled = true;
                    }
                }
                else
                {
                    lblAantalLijnenTekst.Text = "Aantal lijnen is incorrect!";
                }
            }
            {
                
            }
        }

        private void openXML_Click(object sender, EventArgs e)
        {
            if (ofdXML.ShowDialog() == DialogResult.OK)
            {
                lstXML.Items.AddRange(File.ReadAllLines(ofdXML.FileName));
                XMLVariables.XMLFileName = ofdXML.FileName;
                btnConverteer.Enabled = true;
                lblAantalLijnenTekst.Text = "Aantal lijnen is correct, conversie kan beginnen!";
            }
            
        }

        private void btnConverteer_Click(object sender, EventArgs e)
        {

            XMLVariables.XMLDocument = new XmlDocument();
            if (XMLVariables.XMLFileName == null)
            {
                MessageBox.Show("XML bestand is niet ingeladen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XMLVariables.XMLDocument.Load(XMLVariables.XMLFileName);
                XmlNodeList nodes = XMLVariables.XMLDocument.SelectNodes("//en-US/*");

                if (nodes.Count > 0)
                {
                    lstXML.Items.Clear();
                    for (int i = 0; i < txtTextfile.Lines.Length - 1; i++)
                    {
                        nodes[i].InnerText = txtTextfile.Lines[i];

                    }
                    foreach (XmlNode item in nodes)
                    {
                        lstXML.Items.Add(item.OuterXml);
                    }

                }
                else
                {
                    MessageBox.Show("No child nodes were found for 'en-us'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void slaXMLBestandOp_Click(object sender, EventArgs e)
        {
            if (sfdXML.ShowDialog() == DialogResult.OK)
            {
                XMLVariables.XMLDocument.Save(sfdXML.FileName);
            }
        }

        static class XMLVariables
        {
            static public string XMLFileName { get; set; }
            static public XmlDocument XMLDocument { get; set; }
        }

        private void txtTextfile_TextChanged(object sender, EventArgs e)
        {
            if (txtTextfile.Lines.Length == 24)
            {
                if (XMLVariables.XMLFileName == null)
                {
                    lblAantalLijnenTekst.Text = "Aantal lijnen is correct, maar je moet nog een XML bestand inladen!";
                }
                else
                {
                    lblAantalLijnenTekst.Text = "Aantal lijnen is correct, conversie kan beginnen!";
                    btnConverteer.Enabled = true;
                }
            }
            else
            {
                lblAantalLijnenTekst.Text = "Aantal lijnen is incorrect!";
                btnConverteer.Enabled = false;
            }
        }
    }
}
