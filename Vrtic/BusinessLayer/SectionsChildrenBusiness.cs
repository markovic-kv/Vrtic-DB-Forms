using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SectionsChildrenBusiness
    {
        public List<SectionsChildren> AllSectionsChildren()
        { 
            SectionsChildrenRepository sc = new SectionsChildrenRepository();
            List<SectionsChildren> lst = new List<SectionsChildren>();
            lst = sc.GetSectionsChildren();
            var lstVar = from d in lst orderby d.Subject ascending select d;
            List<SectionsChildren> lst2 = new List<SectionsChildren>();
            foreach (var v in lstVar)
            {
                lst2.Add(v);
            }
            return lst2;
        }
  
        public List<SectionsChildren> SectionSearch(string par)
        {
            List<SectionsChildren> lst = new List<SectionsChildren>();
            SectionsChildrenRepository sc = new SectionsChildrenRepository();
            lst = sc.GetSectionsChildren();
            var lstVar = from v in lst where v.Name.StartsWith(par) || v.Surname.StartsWith(par) || v.Subject.StartsWith(par) || v.Grade.StartsWith(par) select v;
            List<SectionsChildren> lst2 = new List<SectionsChildren>();
            foreach (var n in lstVar)
            {
                lst2.Add(n);
            }
            return lst2;
        }
        public List<Sections> SectionsSortedByKey()
        {
            List<Sections> lst = new List<Sections>();
            List<Sections> lst2 = new List<Sections>();
            SectionsRepository sr = new SectionsRepository();
            lst = sr.GetAllSections();
            var lstVar = from o in lst orderby o.GetSetIdSec select o;
            foreach (var n in lstVar)
            {
                lst2.Add(n);
            }
            return lst2;
        }
        public Sections SectionSearchByKey(int par)
        {
            List<Sections> lst = new List<Sections>();
            List<Sections> lst2 = new List<Sections>();
            SectionsRepository sr = new SectionsRepository();
            lst = sr.GetAllSections();
            var lstVar = from o in lst where o.GetSetIdSec == par select o;
            foreach (var n in lstVar)
            {
                lst2.Add(n);
            }
            return lst2[0];
        }
        public string InsertSections(Sections om)
        {
            SectionsRepository sr = new SectionsRepository();
            int insertNum = sr.InsertSections(om);
            if (insertNum > 0)
            {
                return "Uspesan unos";
            }
            else
            {
                return "Neuspesan unos";
            }
        }
        public string UpdateSection(Sections om)
        {
            SectionsRepository sr = new SectionsRepository();
            int insertNum = sr.UpdateSections(om);
            if (insertNum > 0)
            {
                return "Uspesan unos";
            }
            else
            {
                return "Neuspesan unos";
            }
        }

        public string DeleteSection(int id)
        {
            SectionsRepository sr = new SectionsRepository();
            int num = sr.DeleteSections(id);
            if (num > 0)
            {
                return "Uspesno brisanje";
            }
            else
            {
                return "Neuspesno brisanje";
            }
        }
        public int RowNumberOfSectionForSelectedChild(int id)
        {
            SectionsRepository sr = new SectionsRepository();
            int num = sr.NumberOfSectionsGradedForSelectedChild(id);
            return num;
        }
    }
}
