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

            XmlDocument xmlDocument = new XmlDocument();
            if (XMLVariables.XMLFileName == "")
            {
                MessageBox.Show("XML bestand is niet ingeladen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                xmlDocument.Load(XMLVariables.XMLFileName);
                XmlNodeList nodes = xmlDocument.SelectNodes("//en-US/*");

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

        static class XMLVariables
        {
            static public string XMLFileName { get; set; }

        }

        private void slaXMLBestandOp_Click(object sender, EventArgs e)
        {

        }
    }
}
