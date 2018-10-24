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
    public partial class frmChildren : Form
    {
        public frmChildren()
        {
            InitializeComponent();
        }

        private void cmbChildNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

            //

            ChildrenBusiness db = new ChildrenBusiness();
            DataLayer.Models.Children d = new DataLayer.Models.Children();
            TeachersBusiness vb = new TeachersBusiness();
            Teachers vv = new Teachers();
            //string prezimeVaspitaca = "";
            try
            {
                
                int id = int.Parse(cmbChildNumber.Text);
                d = db.SearchChildrenByKey(id);
                cmbTeacherNumber.Text = d.GetSetIdTeacher.ToString();
                cmbRoomNumber.Text = d.GetSetIdRoom.ToString();
                txtName.Text = d.GetSetName;
                txtSurname.Text = d.GetSetSurname;
                txtDay.Text = d.GetSetBirthDate.Day.ToString();
                txtMonth.Text = d.GetSetBirthDate.Month.ToString();
                txtYear.Text = d.GetSetBirthDate.Year.ToString();
                cmbGender.Text = d.GetSetGender;
                txtPhoneNum.Text = d.GetSetPhoneNum;
                int teacherNumber = int.Parse(cmbTeacherNumber.Text);
                vv = vb.SearchTeacherByKey(teacherNumber);
                txtTeacherSurname.Text = vv.GetSetSurname;
                

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
                ChildrenBusiness dbu = new ChildrenBusiness();
                Children dm = new Children();
                dm.GetSetName = txtName.Text;
                dm.GetSetSurname = txtSurname.Text;
                string dan = txtDay.Text;
                string mesec = txtMonth.Text;
                string godina = txtYear.Text;
                DateTime date = new DateTime(int.Parse(godina), int.Parse(mesec), int.Parse(dan));
                dm.GetSetBirthDate = date;
                dm.GetSetGender = cmbGender.Text;
                dm.GetSetPhoneNum = txtPhoneNum.Text;
                dm.GetSetIdTeacher = int.Parse(cmbTeacherNumber.Text);
                dm.GetSetIdRoom = int.Parse(cmbRoomNumber.Text);
                string message = dbu.InsertChild(dm);
                lblMsg.Text = message;
                List<Children> lst = new List<Children>();
                ChildrenRepository cr = new ChildrenRepository();
                lst = cr.GetAllChildren();
                var lstVar = from d in lst where d.GetSetName == txtName.Text && d.GetSetBirthDate == date && dm.GetSetPhoneNum == txtPhoneNum.Text && d.GetSetSurname == txtSurname.Text  select d;                
                foreach (var v in lstVar)
                    cmbChildNumber.Items.Add(v.GetSetIdC);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nepravilan unos " + ex.Message);
            }
        }

        private void cmbTeacherNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Teachers vas = new Teachers();
            TeachersBusiness vb = new TeachersBusiness();
            int vBr;
            try
            {
                vBr = int.Parse(cmbTeacherNumber.Text);
                vas = vb.SearchTeacherByKey(vBr);
                txtTeacherSurname.Text = vas.GetSetSurname;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nepravilan unos " + ex.Message);
            }
        }

        private void frmChildren_Load(object sender, EventArgs e)
        {
            cmbGender.Items.Clear();
            cmbGender.Items.Add("musko");
            cmbGender.Items.Add("zensko");
            try
            {
                cmbRoomNumber.Items.Clear();
                List<Rooms> lstRoom = new List<Rooms>();
                RoomsBusiness rb = new RoomsBusiness();
                lstRoom = rb.AllRooms();
                foreach (var v in lstRoom)
                {
                    cmbRoomNumber.Items.Add(v.GetSetIdRoom.ToString());
                    
                }

                List<Children> lstDeca = new List<Children>();
                ChildrenBusiness db = new ChildrenBusiness();
                lstDeca = db.AllChildrenSortedByKey();
                cmbChildNumber.Items.Clear();
                foreach (var v in lstDeca)
                {
                    cmbChildNumber.Items.Add(v.GetSetIdC.ToString());
                }
                cmbTeacherNumber.Items.Clear();
                List<Teachers> lstVas = new List<Teachers>();
                TeachersBusiness vbi = new TeachersBusiness();
                lstVas = vbi.AllTeacherSortedByKey();
                foreach (var v in lstVas)
                {
                    cmbTeacherNumber.Items.Add(v.GetSetIdT.ToString());
                }

                

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
                ChildrenBusiness dbu = new ChildrenBusiness();
                Children dm = new Children();
                dm.GetSetIdC = int.Parse(cmbChildNumber.Text);
                dm.GetSetName = txtName.Text;
                dm.GetSetSurname = txtSurname.Text;
                string day = txtDay.Text;
                string month = txtMonth.Text;
                string year = txtYear.Text;
                DateTime date = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
                dm.GetSetBirthDate = date;
                dm.GetSetGender = cmbGender.Text;
                dm.GetSetPhoneNum = txtPhoneNum.Text;
                dm.GetSetIdTeacher = int.Parse(cmbTeacherNumber.Text);
                dm.GetSetIdRoom = int.Parse(cmbRoomNumber.Text);
                string msg = dbu.UpdateChild(dm);
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
                ChildrenBusiness db = new ChildrenBusiness();
                Children dm = new Children();
                lblMsg.Text = db.DeleteChildren(int.Parse(cmbChildNumber.Text));
                cmbChildNumber.Items.Remove(cmbChildNumber.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
