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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnViews_Click(object sender, EventArgs e)
        {
            frmViews pre = new frmViews();
            pre.Show();
        }

        private void btnTextSearch_Click(object sender, EventArgs e)
        {
            frmOneParameterView pre = new frmOneParameterView();
            pre.Show();
        }

        private void btnPrecisionSearch_Click(object sender, EventArgs e)
        {
            frmTwoParameters frmdp = new frmTwoParameters();
            frmdp.Show();
        }

        private void btnDataChange_Click(object sender, EventArgs e)
        {
            frmDataChange izp = new frmDataChange();
            izp.Show();
        }
    }
}
