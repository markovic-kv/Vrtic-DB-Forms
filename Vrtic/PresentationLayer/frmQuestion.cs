using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmQuestion : Form
    {
        string choiceGlob;
        public frmQuestion(string choice)
        {
            InitializeComponent();
            choiceGlob = choice;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmTextSearch pre = new frmTextSearch(choiceGlob, txtPar.Text);
            pre.Show();
        }

        private void frmQuestion_Load(object sender, EventArgs e)
        {

        }
    }
}
