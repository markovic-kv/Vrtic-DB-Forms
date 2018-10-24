using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AbsencesRepository //
    {
        public int InsertAbsences(Absences i)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "INSERT INTO Izostanci (DatumPoc, DatumKraj, IdDet) VALUES('" + i.GetSetBeginDate + "', '" + i.GetSetEndDate + "' , '" + i.GetSetIdChild + "')";

                return command.ExecuteNonQuery();
            }
        }
        public List<Absences> GetAllAbsences()
        {
            List<Absences> listToReturn = new List<Absences>();
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "SELECT * FROM Izostanci";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Absences i = new Absences();
                    i.GetSetIdAb = dataReader.GetInt32(0);
                    i.GetSetBeginDate = dataReader.GetDateTime(1);
                    i.GetSetEndDate = dataReader.GetDateTime(2);
                    i.GetSetIdChild = dataReader.GetInt32(3);
                    listToReturn.Add(i);
                }
            }
            return listToReturn;
        }
        public int UpdateAbsences(Absences i)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "update Izostanci set DatumPoc='" + i.GetSetBeginDate + "', DatumKraj='" + i.GetSetEndDate + "', IdDet='" + i.GetSetIdChild + "' where IdIz='" + i.GetSetIdAb + "'";

                return command.ExecuteNonQuery();
            }
        }
        public int DeleteAbsence(int id)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "delete izostanci where idiz = " + id + "";
                return command.ExecuteNonQuery();
            }
        }
        public int NumberOfAbsencesForSelectedChild(int idChild)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "select count(*) from izostanci where iddet = " + idChild + "";

                SqlDataReader reader = command.ExecuteReader();
                int rowNumber = 0;
                while (reader.Read())
                {
                    rowNumber = reader.GetInt32(0);
                }
                return rowNumber;
            }
        }
        public int DeleteAbscencesForChildId(int idChild)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "Delete izostanci where iddet = " + idChild +"";

                return command.ExecuteNonQuery();
            }
        }

    }
}
