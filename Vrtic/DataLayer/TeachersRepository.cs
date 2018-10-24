using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLayer
{
    public class TeachersRepository //
    {
        public int InsertTeachers(Teachers v)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "INSERT INTO Vaspitaci (Ime, Prezime, Jmbg, Pol, Telefon, DatRodjenja, StrSprema) VALUES('" + v.GetSetName + "', '" + v.GetSetSurname + "'," +
                    " '" + v.GetSetSsn + "' , '" + v.GetSetGender + "' , '" + v.GetSetPhoneNum + "' ,  '" + v.GetSetBirthDate + "' , '" + v.GetSetQualification + "')";

                return command.ExecuteNonQuery();
            }
        }
        public List<Teachers> GetAllTeachers()
        {
            List<Teachers> listToReturn = new List<Teachers>();
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "SELECT * FROM Vaspitaci";

                SqlDataReader dataReader = command.ExecuteReader();
                
                while (dataReader.Read())
                {
                    Teachers v = new Teachers();
                    v.GetSetIdT = dataReader.GetInt32(0);
                    v.GetSetName = dataReader.GetString(1);
                    v.GetSetSurname = dataReader.GetString(2);
                    v.GetSetSsn = dataReader.GetString(3);
                    v.GetSetGender = dataReader.GetString(4);
                    v.GetSetPhoneNum = dataReader.GetString(5);
                    v.GetSetBirthDate = dataReader.GetDateTime(6);
                    v.GetSetQualification = dataReader.GetString(7);
                    listToReturn.Add(v);
                }
            }
            return listToReturn;
        }
        public int UpdateTeachers(Teachers v)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "update Vaspitaci set Ime='" + v.GetSetName + "', Prezime= '" + v.GetSetSurname + "', Jmbg= '" + v.GetSetSsn + "', Pol= '" + v.GetSetGender + "', Telefon= '" + v.GetSetPhoneNum + "', DatRodjenja= '" + v.GetSetBirthDate + "', StrSprema= '" + v.GetSetQualification +"' where IdV='" + v.GetSetIdT + "'";

                return command.ExecuteNonQuery();
            }
        }
        public int DeleteTeacher(int idTeacher)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                ChildrenRepository dr = new ChildrenRepository();
                if (dr.NumberOfChildrenAtSelectedTeacher(idTeacher) > 0)
                {
                    MessageBox.Show("Potrebno je prebaciti decu kod drugog vaspitaca a zatim se moze obrisati");
                    command.CommandText = "delete from vaspitaci where idv = 0";
                }
                else
                {
                    SeminarsRepository sr = new SeminarsRepository();
                    sr.DeleteSeminarOnForeignKey(idTeacher);
                    command.CommandText = "delete from vaspitaci where idv =" + idTeacher +"";
                }
                return command.ExecuteNonQuery();

            }
        }



    }
}

