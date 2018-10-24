using BusinessLayer;
using DataLayer.Models;
using PresentationLayer.Models;
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
    public partial class frmNoParameterView : Form
    {
        string choiceGlob;
        public frmNoParameterView(string viewChoice)
        {
            InitializeComponent();
            choiceGlob = viewChoice;
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void NoParameterView_Load(object sender, EventArgs e)
        {
            if (choiceGlob == "vaspitaci")
            {
                TeachersBusiness teachers = new TeachersBusiness();
                List<Teachers> lstTeachers = new List<Teachers>();
                List<TeachersView> lstTeachersView = new List<TeachersView>();
                lstTeachers = teachers.AllTeachers();
                foreach (Teachers v in lstTeachers)
                {
                    int num = v.GetSetIdT;
                    string name = v.GetSetName;
                    string surname = v.GetSetSurname;
                    string ssn = v.GetSetSsn;
                    string gender = v.GetSetGender;
                    string phoneNum = v.GetSetPhoneNum;
                    string birthDate = v.GetSetBirthDate.ToShortDateString();
                    string qualification = v.GetSetQualification;
                    TeachersView tView = new TeachersView();
                    tView.num = num;
                    tView.Name = name;
                    tView.Surname = surname;
                    tView.Ssn = ssn;
                    tView.Gender = gender;
                    tView.PhoneNum = phoneNum;
                    tView.BirthDate = birthDate;
                    tView.Qualification = qualification;
                    lstTeachersView.Add(tView);

                }

                dataGrid.DataSource = lstTeachersView;

            }
            else if (choiceGlob == "deca")
            {
                ChildrenBusiness children = new ChildrenBusiness();
                List<Children> lstChildren = new List<Children>();
                List<ChildrenView> lstChildrenView = new List<ChildrenView>();
                lstChildren = children.AllChildre();
                foreach (DataLayer.Models.Children d in lstChildren)
                {
                    ChildrenView dView = new ChildrenView();
                    dView.Num = d.GetSetIdC;
                    dView.Name = d.GetSetName;
                    dView.Surname = d.GetSetSurname;
                    dView.BirthDate = d.GetSetBirthDate.ToShortDateString();
                    dView.Gender = d.GetSetGender;
                    dView.PhoneNum = d.GetSetPhoneNum;
                    dView.TeacherNumber = d.GetSetIdTeacher;
                    dView.RoomNumber = d.GetSetIdRoom;
                    lstChildrenView.Add(dView);
                }
                dataGrid.DataSource = lstChildrenView;
            }
            else if (choiceGlob == "vaspitaci i seminari")
            {
                List<SeminarsTeachers> lst = new List<SeminarsTeachers>();
                SeminarsTeachersBusiness stb = new SeminarsTeachersBusiness();
                lst = stb.AllSeminarsTeachers();
                dataGrid.DataSource = lst;
            }
            else if (choiceGlob == "izostanci dece")
            {
                List<ChildrenAbsences> lst = new List<ChildrenAbsences>();
                ChildrenAbsencesBusiness cab = new ChildrenAbsencesBusiness();
                lst = cab.AllChildrenAbsences();
                dataGrid.DataSource = lst;
            }
            else if (choiceGlob == "oblasti deca")
            {
                List<SectionsChildren> lst = new List<SectionsChildren>();
                SectionsChildrenBusiness scb = new SectionsChildrenBusiness();
                lst = scb.AllSectionsChildren();
                dataGrid.DataSource = lst;
            }
            else if (choiceGlob == "sve sobe")
            {
                List<Rooms> lst = new List<Rooms>();
                RoomsBusiness rb = new RoomsBusiness();
                lst = rb.AllRooms();
                dataGrid.DataSource = lst;
                dataGrid.Columns[0].HeaderText = "RB";
                dataGrid.Columns[1].HeaderText = "Broj sobe";
                dataGrid.Columns[2].HeaderText = "Velicina";
            }
        }
    }
}
