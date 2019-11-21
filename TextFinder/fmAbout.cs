using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFinder
{
    public partial class fmAbout : Form
    {
        private int pfvWordsSearched;

        public fmAbout()
        {
            InitializeComponent();
        }

        public void fmAbout_Load(object sender, EventArgs e)
        {
            lbSearchedText.Text = WordsSearched.ToString();
        }

        public int WordsSearched
        {
            get
            {
                return pfvWordsSearched;
            }
            set
            {
                pfvWordsSearched = value;
            }
        }

        private void bnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
