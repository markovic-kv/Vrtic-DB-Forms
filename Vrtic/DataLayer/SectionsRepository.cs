using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class SectionsRepository //
    {
        public int InsertSections(Sections o)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "INSERT INTO Oblasti (Predmet, Uspeh, IdDec) VALUES('" + o.GetSetSubject + "', '" + o.GetSetGrade + "' , '" + o.GetSetIdChild + "')";

                return command.ExecuteNonQuery();
            }
        }
        public List<Sections> GetAllSections()
        {
            List<Sections> listToReturn = new List<Sections>();
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "SELECT * FROM Oblasti";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Sections o = new Sections();
                    o.GetSetIdSec = dataReader.GetInt32(0);
                    o.GetSetSubject = dataReader.GetString(1);
                    o.GetSetGrade = dataReader.GetString(2);
                    o.GetSetIdChild = dataReader.GetInt32(3);
                    listToReturn.Add(o);
                }
            }
            return listToReturn;
        }
        public int UpdateSections(Sections o)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "UPDATE Oblasti SET Predmet='" + o.GetSetSubject + "', Uspeh='" + o.GetSetGrade +"', IdDec='" + o.GetSetIdChild + "' where IdOb=" + o.GetSetIdSec + "";

                return command.ExecuteNonQuery();
            }
        }
        //
        public int DeleteSections(int id)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "delete oblasti where idob = " + id + "";
                return command.ExecuteNonQuery();
            }
        }
        public int NumberOfSectionsGradedForSelectedChild(int idChild)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "select count(*) from oblasti where iddec = " + idChild + "";

                SqlDataReader reader = command.ExecuteReader();
                int rowNum = 0;
                while (reader.Read())
                {
                    rowNum = reader.GetInt32(0);
                }
                return rowNum;
            }
        }
    }
}
