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
    public partial class frmTwoParametresQuestion : Form
    {
        string choiceGlob;
        public frmTwoParametresQuestion(string choice)
        {
            InitializeComponent();
            choiceGlob = choice;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (choiceGlob == "bodovi seminari")
            {
                try
                {
                    string low = txtLow.Text;
                    string high = txtHigh.Text;
                    frmTwoParameterView tpv = new frmTwoParameterView(choiceGlob, low, high);
                    tpv.Show();
                }
                catch (Exception ex) { MessageBox.Show("Neispravan unos " + ex.Message); }
            }
            else if (choiceGlob == "deca rodjena")
            {
                string low = txtLow.Text;
                string high = txtHigh.Text;
                frmTwoParameterView dvp = new frmTwoParameterView(choiceGlob, low, high);
                dvp.Show();
            }
            else if (choiceGlob == "deca izostanci")
            {
                string low = txtLow.Text;
                string high = txtHigh.Text;
                frmTwoParameterView dvp = new frmTwoParameterView(choiceGlob, low, high);
                dvp.Show();
            }
        }
    }
}
