using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AbscencesChildrenRepository
    {
        public List<ChildrenAbsences> GetAbscencesChildren()
        {
            List<ChildrenAbsences> listToReturn = new List<ChildrenAbsences>();
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "select Deca.Ime, Deca.Prezime, Deca.DatRodjenja, Deca.Telefon, Izostanci.DatumPoc, Izostanci.DatumKraj from Deca join Izostanci on Deca.IdD = Izostanci.IdDet";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    ChildrenAbsences s = new ChildrenAbsences();
                    s.Name = dataReader.GetString(0);
                    s.Surname = dataReader.GetString(1);
                    s.BirthDate = dataReader.GetDateTime(2).ToShortDateString();
                    s.PhoneNum = dataReader.GetString(3);
                    s.BeginDate = dataReader.GetDateTime(4).ToShortDateString(); 
                    s.EndDate = dataReader.GetDateTime(5).ToShortDateString();
                    listToReturn.Add(s);
                }
            }
            return listToReturn;
        }

    }
}

