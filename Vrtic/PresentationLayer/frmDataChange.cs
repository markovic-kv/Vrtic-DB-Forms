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
    public partial class frmDataChange : Form
    {
        public frmDataChange()
        {
            InitializeComponent();
        }

        private void btnChildren_Click(object sender, EventArgs e)
        {
            frmChildren d = new frmChildren();
            d.Show();
        }

        private void btnAbsence_Click(object sender, EventArgs e)
        {
            frmAbsences iz = new frmAbsences();
            iz.Show();
        }

        private void btnSections_Click(object sender, EventArgs e)
        {
            frmSections ob = new frmSections();
            ob.Show();
        }

        private void btnSeminars_Click(object sender, EventArgs e)
        {
            frmSeminars sem = new frmSeminars();
            sem.Show();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            frmRooms fs = new frmRooms();
            fs.Show();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            frmTeachers vas = new frmTeachers();
            vas.Show();
        }
    }
}
