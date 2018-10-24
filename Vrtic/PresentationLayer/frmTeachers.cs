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
    public partial class frmTeachers : Form
    {
        public frmTeachers()
        {
            InitializeComponent();
        }

        private void frmTeachers_Load(object sender, EventArgs e)
        {
            cmbGender.Items.Clear();
            cmbGender.Items.Add("musko");
            cmbGender.Items.Add("zensko");
            TeachersBusiness tb = new TeachersBusiness();
            List<Teachers> lstTeachers = new List<Teachers>();
            lstTeachers = tb.AllTeacherSortedByKey();
            cmbTeacherNumber.Items.Clear();
            foreach (var v in lstTeachers)
            {
                cmbTeacherNumber.Items.Add(v.GetSetIdT);
            }
        }

        private void cmbTeacherNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            TeachersBusiness tb = new TeachersBusiness();
            Teachers t = new Teachers();
            try
            {
                int id = int.Parse(cmbTeacherNumber.Text);
                t = tb.SearchTeacherByKey(id);
                txtName.Text = t.GetSetName;
                txtSurname.Text = t.GetSetSurname;
                cmbGender.Text = t.GetSetGender;
                txtSsn.Text = t.GetSetSsn;
                txtPhoneNum.Text = t.GetSetPhoneNum;
                txtDay.Text = t.GetSetBirthDate.Day.ToString();
                txtMonth.Text = t.GetSetBirthDate.Month.ToString();
                txtYear.Text = t.GetSetBirthDate.Year.ToString();
                txtQualification.Text = t.GetSetQualification;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nepravilan unos " + ex.Message);
            }
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Teachers t = new Teachers();
                t.GetSetName = txtName.Text;
                t.GetSetSurname = txtSurname.Text;
                t.GetSetGender = cmbGender.Text;
                t.GetSetSsn = txtSsn.Text;
                t.GetSetPhoneNum = txtPhoneNum.Text;
                int year = int.Parse(txtYear.Text);
                int month = int.Parse(txtMonth.Text);
                int day = int.Parse(txtDay.Text);
                DateTime date = new DateTime(year, month, day);
                t.GetSetBirthDate = date;
                t.GetSetQualification = txtQualification.Text;
                TeachersBusiness vb = new TeachersBusiness();
                string msg = vb.InsertTeacher(t);
                lblMsg.Text = msg;
                List<Teachers> lst = new List<Teachers>();
                TeachersRepository tr = new TeachersRepository();
                lst = tr.GetAllTeachers();
                var lstVar = from d in lst where d.GetSetSsn == txtSsn.Text select d;
                foreach (var vc in lstVar)
                    cmbTeacherNumber.Items.Add(vc.GetSetIdT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nepravilan unos " + ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Teachers t = new Teachers();
                t.GetSetIdT = int.Parse(cmbTeacherNumber.Text);
                t.GetSetName = txtName.Text;
                t.GetSetSurname = txtSurname.Text;
                t.GetSetGender = cmbGender.Text;
                t.GetSetSsn = txtSsn.Text;
                t.GetSetPhoneNum = txtPhoneNum.Text;
                int year = int.Parse(txtYear.Text);
                int month = int.Parse(txtMonth.Text);
                int day = int.Parse(txtDay.Text);
                DateTime date = new DateTime(year, month, day);
                t.GetSetBirthDate = date;
                t.GetSetQualification = txtQualification.Text;
                TeachersBusiness vb = new TeachersBusiness();
                string ispis = vb.UpdateTeachers(t);
                lblMsg.Text = ispis;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try {
                TeachersBusiness tb = new TeachersBusiness();
                lblMsg.Text = tb.DeleteTeachers(int.Parse(cmbTeacherNumber.Text));
                cmbTeacherNumber.Items.Remove(cmbTeacherNumber.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
