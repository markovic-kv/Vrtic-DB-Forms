using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class TeachersBusiness
    {
        public List<Teachers> AllTeachers()
        {
            List<Teachers> lst = new List<Teachers>();
            TeachersRepository te = new TeachersRepository();
            lst = te.GetAllTeachers();
            var lstVar = from d in lst orderby d.GetSetSurname ascending select d;
            List<Teachers> lst2 = new List<Teachers>();
            foreach (var v in lstVar)
            {
                lst2.Add(v);
            }
            return lst2;
        }
        public List<Teachers> AllTeacherSortedByKey()
        {
            List<Teachers> lst = new List<Teachers>();
            TeachersRepository te = new TeachersRepository();
            lst = te.GetAllTeachers();
            var lstVar = from d in lst orderby d.GetSetIdT ascending select d;
            List<Teachers> lst2 = new List<Teachers>();
            foreach (var v in lstVar)
            {
                lst2.Add(v);
            }
            return lst2;
        }
        public Teachers SearchTeacherByKey(int id)
        {
            List<Teachers> lst = new List<Teachers>();
            TeachersRepository vas = new TeachersRepository();
            lst = vas.GetAllTeachers();
            var lstVar = from d in lst where d.GetSetIdT == id orderby d.GetSetIdT ascending select d;
            List<Teachers> lst2 = new List<Teachers>();
            foreach (var v in lstVar)
            {
                lst2.Add(v);
            }
            return lst2[0];
        }
        public List<Teachers> SearchByText(string par)
        {
            List<Teachers> lst = new List<Teachers>();
            TeachersRepository vas = new TeachersRepository();
            lst = vas.GetAllTeachers();
            var lstVar = from v in lst where v.GetSetName.StartsWith(par) || v.GetSetSurname.StartsWith(par) || v.GetSetSsn.StartsWith(par) || v.GetSetGender.StartsWith(par) || v.GetSetPhoneNum.StartsWith(par) || v.GetSetQualification.StartsWith(par) select v;
            List<Teachers> lst2 = new List<Teachers>();
            foreach(var n in lstVar)
            {
                lst2.Add(n);
            }
            return lst2;
        }
        public string InsertTeacher(Teachers v)
        {
            TeachersRepository tr = new TeachersRepository();
            int ret = tr.InsertTeachers(v);
            string retText = "";
            if (ret > 0)
            {
                retText = "Uspesan unos";
            }
            else
            {
                retText = "Neuspesan unos";
            }
            return retText;
        }
        public string UpdateTeachers(Teachers v)
        {
            TeachersRepository tr = new TeachersRepository();
            int ret = tr.UpdateTeachers(v);
            string retText = "";
            if (ret > 0)
            {
                retText = "Uspesan unos";
            }
            else
            {
                retText = "Neuspesan unos";
            }
            return retText;
        }
        public string DeleteTeachers(int id)
        {
            TeachersRepository tr = new TeachersRepository();
            int num = tr.DeleteTeacher(id);
            if (num > 0)
            {
                return "Uspesno brisanje";
            }
            else
            {
                return "Neuspesno brisanje";
            }
        }
    }
}
