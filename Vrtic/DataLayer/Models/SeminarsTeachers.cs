using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class SeminarsTeachers
    {
        public string Date { get; set; }
        public int Days { get; set; }
        public int Hours { get; set; }
        public int Points { get; set; }
        public string Topic { get; set; }
        public string Location { get; set; }
        public int TeacherNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
