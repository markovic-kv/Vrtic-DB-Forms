using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Sections //
    {
        private int IdSec;
        private string Subject;
        private string Grade;
        private int IdChild;

        public int GetSetIdSec
        {
            get { return IdSec; }
            set { IdSec = value; }
        }
        public string GetSetSubject
        {
            get { return Subject; }
            set { Subject = value; }
        }
        public string GetSetGrade
        {
            get { return Grade; }
            set { Grade = value; }
        }
        public int GetSetIdChild
        {
            get { return IdChild; }
            set { IdChild = value; }
        }

    }
}
