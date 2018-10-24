using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Seminars
    {
        private int IdS;
        private DateTime Date;
        private int Days;
        private int Hours;
        private int Points;
        private string Topic;
        private string Location;
        private int IdTeacher;

        public int GetSetIdS
        {
            get { return IdS; }
            set { IdS = value; }
        }
        public DateTime GetSetDate
        {
            get { return Date; }
            set { Date = value; }
        }
        public int GetSetDays
        {
            get { return Days; }
            set { Days = value; }
        }
        public int GetSetHours
        {
            get { return Hours; }
            set { Hours = value; }
        }
        public int GetSetPoints
        {
            get { return Points; }
            set { Points = value; }
        }
        public string GetSetTopic
        {
            get { return Topic; }
            set { Topic = value; }
        }
        public string GetSetLocation
        {
            get { return Location; }
            set { Location = value; }
        }
        public int GetSetIdTeacher
        {
            get { return IdTeacher; }
            set { IdTeacher = value; }
        }
    }
}

