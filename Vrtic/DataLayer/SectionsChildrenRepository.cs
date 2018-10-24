using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class SectionsChildrenRepository
    {
        public List<SectionsChildren> GetSectionsChildren()
        {
            List<SectionsChildren> listToReturn = new List<SectionsChildren>();
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "select Oblasti.IdDec, Deca.Ime, Deca.Prezime, Oblasti.Predmet, Oblasti.Uspeh from Oblasti join Deca On Oblasti.IdDec = Deca.IdD";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    SectionsChildren s = new SectionsChildren();
                    s.ChildNumber = dataReader.GetInt32(0);
                    s.Name = dataReader.GetString(1);
                    s.Surname = dataReader.GetString(2);
                    s.Subject = dataReader.GetString(3);
                    s.Grade = dataReader.GetString(4);
                    listToReturn.Add(s);
                }
            }
            return listToReturn;
        }

    }
}

