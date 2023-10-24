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
            }
            {
                
            }
        }
    }
}
