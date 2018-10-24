using BusinessLayer;
using DataLayer;
using DataLayer.Models;
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
    public partial class frmAbsences : Form
    {
        public frmAbsences()
        {
            InitializeComponent();
        }

        private void frmAbsences_Load(object sender, EventArgs e)
        {
            ChildrenAbsencesBusiness cab = new ChildrenAbsencesBusiness();
            List<Absences> lstAbsence = new List<Absences>();
            lstAbsence = cab.AllAbsencesSortedByKey();
            cmbAbsenceNumber.Items.Clear();
            foreach (var v in lstAbsence) { cmbAbsenceNumber.Items.Add(v.GetSetIdAb); }

            ChildrenBusiness cb = new ChildrenBusiness();
            List<Children> lstChildren = cb.AllChildrenSortedByKey();
            cmbChildNumber.Items.Clear();
            foreach (var v in lstChildren) { cmbChildNumber.Items.Add(v.GetSetIdC); }
        }

        

        private void cmbAbsenceNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChildrenAbsencesBusiness cab = new ChildrenAbsencesBusiness();
            Absences ab = new Absences();

            ab = cab.AbsenceSearchByKey(int.Parse(cmbAbsenceNumber.Text));
            cmbChildNumber.Text = ab.GetSetIdChild.ToString();
            txtBeginDay.Text = ab.GetSetBeginDate.Day.ToString();
            txtBeginMonth.Text = ab.GetSetBeginDate.Month.ToString();
            txtBeginYear.Text = ab.GetSetBeginDate.Year.ToString();

            txtEndDay.Text = ab.GetSetEndDate.Day.ToString();
            txtEndMonth.Text = ab.GetSetEndDate.Month.ToString();
            txtEndYear.Text = ab.GetSetEndDate.Year.ToString();
            ab = cab.AbsenceSearchByKey(int.Parse(cmbAbsenceNumber.Text));
        }

        private void cmbChildNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChildrenBusiness cb = new ChildrenBusiness();
            Children ch = new Children();
            ch = cb.SearchChildrenByKey(int.Parse(cmbChildNumber.Text));
            txtChildSurname.Text = ch.GetSetSurname;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                ChildrenAbsencesBusiness cab = new ChildrenAbsencesBusiness();
                Absences ab = new Absences();
                ab.GetSetIdChild = int.Parse(cmbChildNumber.Text);
                DateTime BeginDate = new DateTime(int.Parse(txtBeginYear.Text), int.Parse(txtBeginMonth.Text), int.Parse(txtBeginDay.Text));
                DateTime EndDate = new DateTime(int.Parse(txtEndYear.Text), int.Parse(txtEndMonth.Text), int.Parse(txtEndDay.Text));
                ab.GetSetBeginDate = BeginDate;
                ab.GetSetEndDate = EndDate;
                string msg = cab.InsertAbsence(ab);
                lblMsg.Text = msg;
                List<Absences> lst = new List<Absences>();
                AbsencesRepository ar = new AbsencesRepository();
                lst = ar.GetAllAbsences();
                var lstVar = from d in lst where d.GetSetIdChild == int.Parse(cmbChildNumber.Text) && d.GetSetBeginDate == BeginDate select d;
                foreach (var v in lstVar)
                    cmbAbsenceNumber.Items.Add(v.GetSetIdAb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ChildrenAbsencesBusiness cab = new ChildrenAbsencesBusiness();
                Absences ab = new Absences();
                ab.GetSetIdAb = int.Parse(cmbAbsenceNumber.Text);
                ab.GetSetIdChild = int.Parse(cmbChildNumber.Text);
                DateTime BeginDate = new DateTime(int.Parse(txtBeginYear.Text), int.Parse(txtBeginMonth.Text), int.Parse(txtBeginDay.Text));
                DateTime EndDate = new DateTime(int.Parse(txtEndYear.Text), int.Parse(txtEndMonth.Text), int.Parse(txtEndDay.Text));
                ab.GetSetBeginDate = BeginDate;
                ab.GetSetEndDate = EndDate;
                string msg = cab.UpdateAbsence(ab);
                lblMsg.Text = msg;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ChildrenAbsencesBusiness cab = new ChildrenAbsencesBusiness();
                lblMsg.Text = cab.DeleteAbsence(int.Parse(cmbAbsenceNumber.Text));
                cmbAbsenceNumber.Items.Remove(cmbAbsenceNumber.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
