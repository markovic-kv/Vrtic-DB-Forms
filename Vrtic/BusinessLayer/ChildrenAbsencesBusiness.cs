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
    public class ChildrenAbsencesBusiness
    {
        public List<ChildrenAbsences> AllChildrenAbsences()
        {
            AbscencesChildrenRepository acr = new AbscencesChildrenRepository();
            List<ChildrenAbsences> lst = new List<ChildrenAbsences>();
            lst = acr.GetAbscencesChildren();
            var lstVar = from d in lst orderby d.BeginDate ascending select d;
            List<ChildrenAbsences> lst2 = new List<ChildrenAbsences>();
            foreach (var v in lstVar)
            {
                lst2.Add(v);
            }
            return lst2;
        }
        public List<ChildrenAbsences> TextSearch(string par)
        {
            List<ChildrenAbsences> lst = new List<ChildrenAbsences>();
            AbscencesChildrenRepository acr = new AbscencesChildrenRepository();
            lst = acr.GetAbscencesChildren();
            var lstVar = from v in lst where v.Name.StartsWith(par) || v.Surname.StartsWith(par) || v.PhoneNum.StartsWith(par)  select v;
            List<ChildrenAbsences> lst2 = new List<ChildrenAbsences>();
            foreach (var n in lstVar)
            {
                lst2.Add(n);
            }
            return lst2;
        }
        public List<ChildrenAbsences> ChildrenByAbsence(string low, string high)
        {
            DateTime lowDate = Convert.ToDateTime(low);
            DateTime highDate = Convert.ToDateTime(high);
            List<ChildrenAbsences> lst = new List<ChildrenAbsences>();
            AbscencesChildrenRepository acr = new AbscencesChildrenRepository();
            lst = acr.GetAbscencesChildren();
            var lstVar = from d in lst where Convert.ToDateTime(d.BeginDate) >= lowDate && Convert.ToDateTime(d.BeginDate) <= highDate select d;
            List <ChildrenAbsences> lst2 = new List<ChildrenAbsences>();
            foreach (var n in lstVar)
            {
                lst2.Add(n);
            }
            return lst2;
        }
        public List<Absences> AllAbsencesSortedByKey()
        {
            List<Absences> lst = new List<Absences>();
            List<Absences> lst2 = new List<Absences>();
            AbsencesRepository ar = new AbsencesRepository();
            lst = ar.GetAllAbsences();
            var lstVar = from i in lst orderby i.GetSetIdAb select i;
            foreach (var n in lstVar)
            {
                lst2.Add(n);
            }
            return lst2;
        }
        public Absences AbsenceSearchByKey(int par)
        {
            
            List<Absences> lst = new List<Absences>();
            List<Absences> lst2 = new List<Absences>();
            AbsencesRepository ar = new AbsencesRepository();
            lst = ar.GetAllAbsences();
            var lstVar = from i in lst where i.GetSetIdAb == par select i;
            foreach (var n in lstVar)
            {
                lst2.Add(n);
            }
            
            return lst2[0];
        }
        public string InsertAbsence(Absences im)
        {
            AbsencesRepository ar = new AbsencesRepository();
            int insertNum = ar.InsertAbsences(im);
            if (insertNum > 0)
                return "Uspesan insert";
            else
                return "Neuspesan insert";
        }
        public string UpdateAbsence(Absences a)
        {
            AbsencesRepository ar = new AbsencesRepository();
            int insertNum = ar.UpdateAbsences(a);
            if (insertNum > 0)
                return "Uspesan update";
            else
                return "Neuspesan update";
        }
        public string DeleteAbsence(int id)
        {
            AbsencesRepository ar = new AbsencesRepository();
            int num = ar.DeleteAbsence(id);
            if (num > 0)
            {
                return "Uspesno brisanje";
            }
            else
            {
                return "Neuspesno brisanje";
            }
        }
        public int RowNumberOfAbsenceForSelectedChild(int id)
        {
            AbsencesRepository ar = new AbsencesRepository();
            int num = ar.NumberOfAbsencesForSelectedChild(id);
            return num;
        }
    }
}
