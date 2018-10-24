using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class SeminarsTeachersRepository
    {
        public List<SeminarsTeachers> GetSeminarsTeachers()
        {
            List<SeminarsTeachers> listToReturn = new List<SeminarsTeachers>();
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "select Seminari.Datum, Seminari.Dana, Seminari.Sati, Seminari.Bodovi, Seminari.Tema, Seminari.Mesto, Seminari.IdVa, Vaspitaci.Ime, Vaspitaci.Prezime from Seminari join Vaspitaci on Seminari.IdVa = Vaspitaci.IdV";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    SeminarsTeachers s = new SeminarsTeachers();
                    s.Date = dataReader.GetDateTime(0).ToShortDateString();
                    s.Days = dataReader.GetInt32(1);
                    s.Hours = dataReader.GetInt32(2);
                    s.Points = dataReader.GetInt32(3);
                    s.Topic = dataReader.GetString(4);
                    s.Location = dataReader.GetString(5);
                    s.TeacherNumber = dataReader.GetInt32(6);
                    s.Name = dataReader.GetString(7);
                    s.Surname = dataReader.GetString(8);
                    listToReturn.Add(s);
                }
            }
            return listToReturn;
        }
    }
}
