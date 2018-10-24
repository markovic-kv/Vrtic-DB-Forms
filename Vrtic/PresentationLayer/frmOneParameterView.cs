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
    public partial class frmOneParameterView : Form
    {
        public frmOneParameterView()
        {
            InitializeComponent();
        }

        private void btnTeachersSearch_Click(object sender, EventArgs e)
        {
            frmQuestion pre = new frmQuestion("vaspitac");
            pre.Show();

        }

        private void frmOneParameterView_Load(object sender, EventArgs e)
        {

        }

        private void btnChildrenSearch_Click(object sender, EventArgs e)
        {
            frmQuestion pre = new frmQuestion("deca");
            pre.Show();
        }

        private void btnSeminarsSearch_Click(object sender, EventArgs e)
        {
            frmQuestion pre = new frmQuestion("seminari");
            pre.Show();
        }

        private void btnAbsenceSearch_Click(object sender, EventArgs e)
        {
            frmQuestion pre = new frmQuestion("deca izostanci");
            pre.Show();
        }

        private void btnSectionsSearch_Click(object sender, EventArgs e)
        {
            frmQuestion pre = new frmQuestion("oblasti deca");
            pre.Show();
        }
    }
}
