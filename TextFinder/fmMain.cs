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

namespace TextFinder
{
    public partial class fmMain : Form
    {
        private int wordsFound;
        private int wordsSearched = 0;

        public fmMain()
        {
            InitializeComponent();
        }

        private void tsmiFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiDataFind_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader sr = new StreamReader("poem.txt"))
            {
                string buf;

                while ((buf = sr.ReadLine()) != null)
                {
                    sb.AppendLine(buf);
                }
            }
            rtbPoem.Text = sb.ToString();
        }

        private void tsmiHelpAbout_Click(object sender, EventArgs e)
        {
            fmAbout form = new fmAbout();
            form.WordsSearched = wordsSearched;
            form.Show();
        }

        private void bnFind_Click(object sender, EventArgs e)
        {
            wordsFound = 0;
            int index = 0;
            rtbPoem.SelectAll();
            rtbPoem.SelectionBackColor = Color.White;
            while (index < rtbPoem.Text.LastIndexOf(tbText.Text))
            {
                rtbPoem.Find(tbText.Text, index, rtbPoem.TextLength, RichTextBoxFinds.None);
                rtbPoem.SelectionBackColor = Color.Yellow;
                index = rtbPoem.Text.IndexOf(tbText.Text, index) + 1;
                wordsFound++;
            }

            tsslStatus.Text = $"Found {wordsFound} occurences of {tbText.Text}";
            wordsSearched++;
        }
    }
}
