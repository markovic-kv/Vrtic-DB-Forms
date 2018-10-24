using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Teachers
    {
        private int IdT;
        private string Name;
        private string Surname;
        private string Ssn;
        private string Gender;
        private string PhoneNum;
        private DateTime BirthDate;
        private string Qualification;

        public int GetSetIdT
        {
            get { return IdT; }
            set { IdT = value; }
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
        public string GetSetSsn
        {
            get { return Ssn; }
            set { Ssn = value; }
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
        public DateTime GetSetBirthDate
        {
            get {return BirthDate; }
            set { BirthDate = value; }
        }
        public string GetSetQualification
        {
            get { return Qualification; }
            set { Qualification = value; }
        }


    }
}

