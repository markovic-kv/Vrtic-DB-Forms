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
    public partial class frmSeminars : Form
    {
        public frmSeminars()
        {
            InitializeComponent();
        }

        private void frmSeminars_Load(object sender, EventArgs e)
        {
            //bogacenje kombo boxa seminari brojevi
            cmbPoints.Items.Clear();
            cmbPoints.Items.Add("0"); cmbPoints.Items.Add("1"); cmbPoints.Items.Add("2"); cmbPoints.Items.Add("3"); cmbPoints.Items.Add("4"); cmbPoints.Items.Add("5");
            cmbDays.Items.Clear();
            cmbDays.Items.Add("1");cmbDays.Items.Add("2");
            cmbDays.Items.Add("3"); cmbDays.Items.Add("4"); cmbDays.Items.Add("5");
            cmbDays.Items.Add("6");cmbDays.Items.Add("7");
            cmbSeminarNumber.Items.Clear();
            SeminarsTeachersBusiness stb = new SeminarsTeachersBusiness();
            List<Seminars> lstSeminars = new List<Seminars>();
            lstSeminars = stb.AllSeminarsSortedByKey();
            foreach (var v in lstSeminars)
            {
                cmbSeminarNumber.Items.Add(v.GetSetIdS);
            }
            //bogacenje kombo boxa vaspitaci brojevi
            cmbTeacherNumber.Items.Clear();
            TeachersBusiness tb = new TeachersBusiness();
            List<Teachers> lstTeacher = new List<Teachers>();
            lstTeacher = tb.AllTeacherSortedByKey();
            foreach (var v in lstTeacher)
            {
                cmbTeacherNumber.Items.Add(v.GetSetIdT);
            }
        }

        private void cmbSeminarNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Seminars sem = new Seminars();
                SeminarsTeachersBusiness stb = new SeminarsTeachersBusiness();
                sem = stb.SeminarSearchByKey(int.Parse(cmbSeminarNumber.Text));
                cmbTeacherNumber.Text = sem.GetSetIdTeacher.ToString();
                txtDay.Text = sem.GetSetDate.Day.ToString();
                txtMonth.Text = sem.GetSetDate.Month.ToString();
                txtYear.Text = sem.GetSetDate.Year.ToString();
                cmbDays.Text = sem.GetSetDays.ToString();
                txtHours.Text = sem.GetSetHours.ToString();
                cmbPoints.Text = sem.GetSetPoints.ToString();
                txtTopic.Text = sem.GetSetTopic;
                txtLocation.Text = sem.GetSetLocation;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbTeacherNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Teachers t = new Teachers();
                TeachersBusiness tb = new TeachersBusiness();
                t = tb.SearchTeacherByKey(int.Parse(cmbTeacherNumber.Text));
                txtTeacherSurname.Text = t.GetSetSurname;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Seminars sem = new Seminars();
                sem.GetSetIdTeacher = int.Parse(cmbTeacherNumber.Text);
                DateTime datum = new DateTime(int.Parse(txtYear.Text), int.Parse(txtMonth.Text), int.Parse(txtDay.Text));
                sem.GetSetDate = datum;
                sem.GetSetDays = int.Parse(cmbDays.Text);
                sem.GetSetHours = int.Parse(txtHours.Text);
                sem.GetSetPoints = int.Parse(cmbPoints.Text);
                sem.GetSetTopic = txtTopic.Text;
                sem.GetSetLocation = txtLocation.Text;
                SeminarsTeachersBusiness stb = new SeminarsTeachersBusiness();
                lblMsg.Text = stb.InsertSeminars(sem);
                List<Seminars> lst = new List<Seminars>();
                SeminarsRepository sr = new SeminarsRepository();
                lst = sr.GetAllSeminars();
                var lstVar = from d in lst where d.GetSetIdTeacher == int.Parse(cmbTeacherNumber.Text) && d.GetSetDate == datum && d.GetSetLocation == txtLocation.Text select d;
                foreach (var v in lstVar)
                    cmbSeminarNumber.Items.Add(v.GetSetIdS);
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
                Seminars sem = new Seminars();
                sem.GetSetIdS = int.Parse(cmbSeminarNumber.Text);
                sem.GetSetIdTeacher = int.Parse(cmbTeacherNumber.Text);
                DateTime datum = new DateTime(int.Parse(txtYear.Text), int.Parse(txtMonth.Text), int.Parse(txtDay.Text));
                sem.GetSetDate = datum;
                sem.GetSetDays = int.Parse(cmbDays.Text);
                sem.GetSetHours = int.Parse(txtHours.Text);
                sem.GetSetPoints = int.Parse(cmbPoints.Text);
                sem.GetSetTopic = txtTopic.Text;
                sem.GetSetLocation = txtLocation.Text;
                SeminarsTeachersBusiness vsb = new SeminarsTeachersBusiness();
                lblMsg.Text = vsb.UpdateSeminar(sem);
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
                SeminarsTeachersBusiness vsb = new SeminarsTeachersBusiness();
                lblMsg.Text = vsb.DeleteSeminar(int.Parse(cmbSeminarNumber.Text));
                cmbSeminarNumber.Items.Remove(cmbSeminarNumber.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

