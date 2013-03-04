using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kerbal_Memorial
{
    public partial class Form1 : Form
    {
        string kn;
        bool ba;
        int ks;

        public Form1()
        {           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            List<CrewMember>DeadKerbals = new List<CrewMember>();
       
            string indexer = "indexed";
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader PersistenceFile = new System.IO.StreamReader(OpenFileDialog1.FileName);
                do
                {
                    indexer = PersistenceFile.ReadLine();

                    if (indexer.Contains("name") == true)
                    {
                        indexer = indexer.Remove(0, 10);
                        kn = indexer;
                        richTextBox1.AppendText(indexer);
                        richTextBox1.AppendText(Environment.NewLine);
                    }

                    if (indexer.Contains("badS") == true)
                    {
                        indexer = indexer.Remove(0, 10);
                        //ba = indexer;
                        richTextBox1.AppendText(indexer);
                        richTextBox1.AppendText(Environment.NewLine);
                        ba = Boolean.Parse(indexer);
                    }

                    if (indexer.Contains("state") == true)
                    {
                        indexer = indexer.Remove(0, 10);
                        //ks = indexer;
                        richTextBox1.AppendText(indexer);
                        richTextBox1.AppendText(Environment.NewLine);
                        richTextBox1.AppendText(Environment.NewLine);
                        ks = int.Parse(indexer);
                        DeadKerbals.Add(new CrewMember(kn, ks, ba));

                    }

                } while (indexer.Contains("VESSEL") != true);
            } 


        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "sfs files (*.sfs)|*.sfs|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

        }

        public bool True { get; set; }
    }
}
