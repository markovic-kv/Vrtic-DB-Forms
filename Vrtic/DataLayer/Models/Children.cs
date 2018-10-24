using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Children //
    {
        private int IdC;
        private string Name;
        private string Surname;
        private DateTime BirthDate;
        private string Gender;
        private string PhoneNum;
        private int IdTeacher;
        private int IdRoom;

        public int GetSetIdC
        {
            get { return IdC; }
            set { IdC = value; }
        }
        public string GetSetName
        {
            get { return Name; }
            set { Name = value; }
        }
        public string GetSetSurname
        {
            get { return Surname; }
            set { Surname = value; }
        }
        public DateTime GetSetBirthDate
        {
            get { return BirthDate; }
            set { BirthDate = value; }
        }
        public string GetSetGender
        {
            get { return Gender; }
            set { Gender = value; }
        }
        public string GetSetPhoneNum
        {
            get { return PhoneNum; }
            set { PhoneNum = value; }
        }
        public int GetSetIdTeacher
        {
            get { return IdTeacher; }
            set { IdTeacher = value; }
        }
             public int GetSetIdRoom
        {
            get { return IdRoom; }
            set { IdRoom = value; }
        }

    }
}
