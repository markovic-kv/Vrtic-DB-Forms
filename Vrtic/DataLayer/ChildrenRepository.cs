using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ChildrenRepository //
    {
        public int InsertChildren(Children d)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "INSERT INTO Deca (Ime, Prezime, DatRodjenja, Pol, Telefon, IdVa, IdSo) VALUES('" + d.GetSetName + "', '" + d.GetSetSurname + "'," +
                    " '" + d.GetSetBirthDate + "' , '" + d.GetSetGender + "' , '" + d.GetSetPhoneNum + "' ,  '" + d.GetSetIdTeacher + "' , '" + d.GetSetIdRoom + "')";

                return command.ExecuteNonQuery();
            }
        }
        public List<Children> GetAllChildren()
        {
            List<Children> listToReturn = new List<Children>();
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "SELECT * FROM Deca";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Children d = new Children();
                    d.GetSetIdC = dataReader.GetInt32(0);
                    d.GetSetName = dataReader.GetString(1);
                    d.GetSetSurname = dataReader.GetString(2);
                    d.GetSetBirthDate = dataReader.GetDateTime(3);
                    d.GetSetGender = dataReader.GetString(4);
                    d.GetSetPhoneNum = dataReader.GetString(5);
                    d.GetSetIdTeacher = dataReader.GetInt32(6);
                    d.GetSetIdRoom = dataReader.GetInt32(7);
                    listToReturn.Add(d);
                }
            }
            return listToReturn;
        }
        public int UpdateChildren(Children d)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "UPDATE Deca SET Ime='" + d.GetSetName + "', Prezime='" + d.GetSetSurname + "', DatRodjenja='" + d.GetSetBirthDate+ "', Pol= '" + d.GetSetGender + "', Telefon= '" + d.GetSetPhoneNum + "', IdVa= '" + d.GetSetIdTeacher + "', IdSo= '" + d.GetSetIdRoom+ "' WHERE IdD='" + d.GetSetIdC + "'";

                return command.ExecuteNonQuery();
            }
        }

        public int DeleteChildren(int id)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                AbsencesRepository ir = new AbsencesRepository();
                if (ir.NumberOfAbsencesForSelectedChild(id) > 0)
                {
                    ir.DeleteAbscencesForChildId(id);
                }
                command.CommandText = "delete deca where idd = " + id + "";
                
                return command.ExecuteNonQuery();
            }
        }
        public int NumberOfChildrenAtSelectedTeacher(int idVaspitaca)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "select count(*) from deca where idva = " + idVaspitaca + "";

                SqlDataReader reader = command.ExecuteReader();
                int rowNumber = 0;
                while (reader.Read())
                {
                    rowNumber = reader.GetInt32(0);
                }
                return rowNumber;
            }
        }
        public int NumberOfChildrenInSelectedRoom(int idRoom)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "select count(*) from deca where idso = " + idRoom + "";

                SqlDataReader reader = command.ExecuteReader();
                int rowNumber = 0;
                while (reader.Read())
                {
                    rowNumber = reader.GetInt32(0);
                }
                return rowNumber;
            }
        }

    }
}
