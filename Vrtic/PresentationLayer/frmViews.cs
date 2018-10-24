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
    public partial class frmViews : Form
    {
        public frmViews()
        {
            InitializeComponent();
        }

        private void btnVaspitaci_Click(object sender, EventArgs e)
        {
            frmNoParameterView pregFrm = new frmNoParameterView("vaspitaci");
            pregFrm.Show();
        }

        private void btnDeca_Click(object sender, EventArgs e)
        {
            frmNoParameterView pregFrm = new frmNoParameterView("deca");
            pregFrm.Show();
        }

        private void btnVaspitaciSeminari_Click(object sender, EventArgs e)
        {
            frmNoParameterView pregFrm = new frmNoParameterView("vaspitaci i seminari");
            pregFrm.Show();
        }

        private void btnIzostanciDece_Click(object sender, EventArgs e)
        {
            frmNoParameterView pregFrm = new frmNoParameterView("izostanci dece");
            pregFrm.Show();
        }

        private void btnOblastideca_Click(object sender, EventArgs e)
        {
            frmNoParameterView pregFrm = new frmNoParameterView("oblasti deca");
            pregFrm.Show();
        }

        private void btnSobe_Click(object sender, EventArgs e)
        {
            frmNoParameterView pregFrm = new frmNoParameterView("sve sobe");
            pregFrm.Show();
        }
    }
}
