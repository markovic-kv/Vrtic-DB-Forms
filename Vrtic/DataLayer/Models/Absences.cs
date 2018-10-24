using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Absences //
    {
        private int IdAb;
        private DateTime BeginDate;
        private DateTime EndDate;
        private int IdChild;

        public int GetSetIdAb
        {
            get { return IdAb; }
            set { IdAb = value; }
        }
        public DateTime GetSetBeginDate
        {
            get { return BeginDate; }
            set { BeginDate = value; }
        }
        public DateTime GetSetEndDate
        {
            get { return EndDate; }
            set { EndDate = value; }
        }
        public int GetSetIdChild
        {
            get { return IdChild; }
            set { IdChild = value; }
        }
    }
}
