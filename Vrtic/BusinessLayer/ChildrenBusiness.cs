using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ChildrenBusiness
    {
        public List<Children> AllChildre()
        {
            List<Children> lst = new List<Children>();
            ChildrenRepository vas = new ChildrenRepository();
            lst = vas.GetAllChildren();
            var varLst = from d in lst orderby d.GetSetSurname select d;
            List<Children> lst2 = new List<Children>();
            foreach (var v in varLst)
            {
                lst2.Add(v);
            }
            return lst2;
        }
        public List<Children> TextSearch(string par)
        {
            List<Children> lst = new List<Children>();
            ChildrenRepository vas = new ChildrenRepository();
            lst = vas.GetAllChildren();
            var lstVar = from v in lst where v.GetSetName.StartsWith(par) || v.GetSetSurname.StartsWith(par) || v.GetSetGender.StartsWith(par) || v.GetSetPhoneNum.StartsWith(par) select v;
            List<Children> lst2 = new List<Children>();
            foreach (var n in lstVar)
            {
                lst2.Add(n);
            }
            return lst2;
        }
        public List<Children> ChildrenBornOnDate(string low, string high)
        {
            List<Children> lst = new List<Children>();
            ChildrenRepository vas = new ChildrenRepository();
            lst = vas.GetAllChildren();
            DateTime lowDate = Convert.ToDateTime(low);
            DateTime highDate = Convert.ToDateTime(high);
            var lstVar = from d in lst where d.GetSetBirthDate >= lowDate && d.GetSetBirthDate <= highDate select d;
            List<Children> lst2 = new List<Children>();
            foreach (var v in lstVar)
            {
                lst2.Add(v);
            }
            return lst2;
        }
        public string InsertChild(Children d)
        {
            ChildrenRepository dr = new ChildrenRepository();
            int ret = dr.InsertChildren(d);
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
        public string UpdateChild(Children d)
        {
            ChildrenRepository dr = new ChildrenRepository();
            int ret = dr.UpdateChildren(d);
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
        public List<Children> AllChildrenSortedByKey()
        {
            List<Children> lst = new List<Children>();
            ChildrenRepository ch = new ChildrenRepository();
            lst = ch.GetAllChildren();
            var lstVar = from d in lst orderby d.GetSetIdC ascending select d;
            List<Children> lst2 = new List<Children>();
            foreach (var v in lstVar)
            {
                lst2.Add(v);
            }
            return lst2;
        }
        public Children SearchChildrenByKey(int id)
        {
            List<Children> lst = new List<Children>();
            ChildrenRepository ch = new ChildrenRepository();
            lst = ch.GetAllChildren();
            var lstVar = from d in lst where d.GetSetIdC == id orderby d.GetSetIdC ascending select d;
            List<Children> lst2 = new List<Children>();
            foreach (var v in lstVar)
            {
                lst2.Add(v);
            }
            return lst2[0];
        }
        public string DeleteChildren(int id)
        {
            ChildrenRepository ch = new ChildrenRepository();
            int i = ch.DeleteChildren(id);
            if (i > 0) return "Uspesno brisanje";
            else return "Neuspesno brisanje";
        }

    }
}
