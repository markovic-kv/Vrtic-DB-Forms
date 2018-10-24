using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class SeminarsRepository //
    {
        public int InsertSeminar(Seminars v)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "INSERT INTO Seminari (Datum, Dana, Sati, Bodovi, Tema, Mesto, IdVa) VALUES('" + v.GetSetDate + "', '" + v.GetSetDays + "'," +
                    " '" + v.GetSetHours + "' , '" + v.GetSetPoints + "' , '" + v.GetSetTopic + "' ,  '" + v.GetSetLocation + "' , '" + v.GetSetIdTeacher + "')";

                return command.ExecuteNonQuery();
            }
        }
        public List<Seminars> GetAllSeminars()
        {
            List<Seminars> listToReturn = new List<Seminars>();
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "SELECT * FROM Seminari";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Seminars s = new Seminars();
                    s.GetSetIdS = dataReader.GetInt32(0);
                    s.GetSetDate = dataReader.GetDateTime(1);
                    s.GetSetDays = dataReader.GetInt32(2);
                    s.GetSetHours = dataReader.GetInt32(3);
                    s.GetSetPoints = dataReader.GetInt32(4);
                    s.GetSetTopic = dataReader.GetString(5);
                    s.GetSetLocation = dataReader.GetString(6);
                    s.GetSetIdTeacher = dataReader.GetInt32(7);
                    listToReturn.Add(s);
                }
            }
            return listToReturn;
        }
        public int UpdateSeminars(Seminars v)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "update Seminari set Datum='" + v.GetSetDate + "', Dana='" + v.GetSetDays + "', Sati='" + v.GetSetHours + "', Bodovi= '" + v.GetSetPoints + "', Tema='" + v.GetSetTopic + "', Mesto='" + v.GetSetLocation + "', IdVa='" + v.GetSetIdTeacher + "' where idS='" + v.GetSetIdS + "'";

                return command.ExecuteNonQuery();
            }
        }
        public int DeleteSeminars(int id)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "DELETE FROM seminari where ids = " + id + "";

                return command.ExecuteNonQuery();
            }
        }
        public int RowNumberOfSeminarsForSelectedTeacher(int idTeacher)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "SELECT COUNT(*) FROM seminari where idva = " + idTeacher + "";

                SqlDataReader reader = command.ExecuteReader();
                int rowNum = 0;
                while (reader.Read())
                {
                    rowNum = reader.GetInt32(0);
                }
                return rowNum;
            }
        }
        public int DeleteSeminarOnForeignKey(int fk)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "DELETE FROM seminari where idva = " + fk + "";

                return command.ExecuteNonQuery();
            }
        }
    }
}

