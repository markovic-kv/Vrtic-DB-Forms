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
    public class SeminarsTeachersBusiness
    {
        public List<SeminarsTeachers> AllSeminarsTeachers()
        {
            List<SeminarsTeachers> lst = new List<SeminarsTeachers>();
            SeminarsTeachersRepository str = new SeminarsTeachersRepository();
            lst = str.GetSeminarsTeachers();
            var lstVar = from s in lst orderby s.Surname ascending select s;
            List<SeminarsTeachers> lst2 = new List<SeminarsTeachers>();
            foreach (var v in lstVar)
            {
                lst2.Add(v);
            }
            return lst2;
        }
        public List<Seminars> SearchByText(string par)
        {
            List<Seminars> lst = new List<Seminars>();
            SeminarsRepository sr = new SeminarsRepository();
            lst = sr.GetAllSeminars();
            var lstVar = from v in lst where v.GetSetTopic.StartsWith(par) || v.GetSetLocation.StartsWith(par)  select v;
            List<Seminars> lst2 = new List<Seminars>();
            foreach (var n in lstVar)
            {
                lst2.Add(n);
            }
            return lst2;
        }
        public List<SeminarsTeachers> SeminarsTeachersForPoints(int low, int high)
        {
            SeminarsTeachersRepository str = new SeminarsTeachersRepository();
            List<SeminarsTeachers> lstTe = new List<SeminarsTeachers>();
            lstTe = str.GetSeminarsTeachers();
            var varLst = from s in lstTe where s.Points >= low && s.Points <= high select s;
            List<SeminarsTeachers> lstSv2 = new List<SeminarsTeachers>();
            foreach (var n in varLst)
            {
                lstSv2.Add(n);
            }
            return lstSv2;
        }
        public List<Seminars> AllSeminarsSortedByKey()
        {
            List<Seminars> lstSeminars = new List<Seminars>();
            SeminarsRepository sem = new SeminarsRepository();
            lstSeminars = sem.GetAllSeminars();
            var varLst = from s in lstSeminars orderby s.GetSetIdS select s;
            List<Seminars> lstSeminari2 = new List<Seminars>();
            foreach (var v in varLst)
            {
                lstSeminari2.Add(v);
            }
            return lstSeminari2;
        }
        public Seminars SeminarSearchByKey(int par)
        {
            List<Seminars> lstSeminars = new List<Seminars>();
            SeminarsRepository sem = new SeminarsRepository();
            lstSeminars = sem.GetAllSeminars();
            var varLst = from s in lstSeminars where s.GetSetIdS == par select s;
            List<Seminars> lstSeminari2 = new List<Seminars>();
            foreach (var v in varLst)
            {
                lstSeminari2.Add(v);
            }
            return lstSeminari2[0];

        }
        public string InsertSeminars(Seminars sem)
        {
            SeminarsRepository semrep = new SeminarsRepository();
            int insertNum = semrep.InsertSeminar(sem);
            string message = "";
            if (insertNum > 0)
            {
                message = "Uspesan unos";
            }
            else
            {
                message = "Neuspesan unos";
            }
            return message;
        }
        public string UpdateSeminar(Seminars sem)
        {
            SeminarsRepository semrep = new SeminarsRepository();
            int insertNum = semrep.UpdateSeminars(sem);
            string message = "";
            if (insertNum > 0)
            {
                message = "Uspesan unos";
            }
            else
            {
                message = "Neuspesan unos";
            }
            return message;
        }
        public string DeleteSeminar(int id)
        {
            SeminarsRepository sr = new SeminarsRepository();
            int num = sr.DeleteSeminars(id);
            if (num > 0)
            {
                return "Uspesno brisanje";
            }
            else
            {
                return "Neuspesni brisanje";
            }
        }
        public int RowNumberOfSeminarsByTeacherId(int idTeacher)
        {
            SeminarsRepository sr = new SeminarsRepository();
            int num = sr.RowNumberOfSeminarsForSelectedTeacher(idTeacher);
            return num;
        }
    }
}
