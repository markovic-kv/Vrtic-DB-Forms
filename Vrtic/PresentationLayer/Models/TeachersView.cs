using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Models
{
    public class TeachersView
    {
        public int num { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Ssn { get; set; }
        public string Gender { get; set; }
        public string PhoneNum { get; set; }
        public string BirthDate { get; set; }
        public string Qualification { get; set; }
    }
}
