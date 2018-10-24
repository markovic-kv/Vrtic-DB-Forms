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
    public class RoomsRepository //
    {
        public int InsertRooms(Rooms s)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "INSERT INTO Sobe (BrSobe, Velicina) VALUES('" + s.GetSetRoomNum + "', '" + s.GetSetSize + "')";

                return command.ExecuteNonQuery();
            }
        }
        public List<Rooms> GetAllRooms()
        {
            List<Rooms> listToReturn = new List<Rooms>();
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "SELECT * FROM Sobe";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Rooms s = new Rooms();
                    s.GetSetIdRoom = dataReader.GetInt32(0);
                    s.GetSetRoomNum = dataReader.GetInt32(1);
                    s.GetSetSize = dataReader.GetString(2);
                    listToReturn.Add(s);
                }
            }
            return listToReturn;
        }
        public int UpdateRooms(Rooms s)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "UPDATE Sobe SET Velicina= '" + s.GetSetSize + "' where brSobe=" + s.GetSetRoomNum + "";

                return command.ExecuteNonQuery();
            }
        }
        private int ReturnRoomsPrimaryKey(int roomNumber)
        {
            int key = 0;
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "SELECT * FROM Sobe where brsobe=" + roomNumber +"";

                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    key = dataReader.GetInt32(0);
                }
            }
            return key;
        }
        public int DeleteRoom(int roomNumber)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                int pk = ReturnRoomsPrimaryKey(roomNumber);
                ChildrenRepository dr = new ChildrenRepository();
                if (dr.NumberOfChildrenInSelectedRoom(pk) > 0)
                {
                    MessageBox.Show("Potrebno je prebaciti decu u drugu sobu");
                    command.CommandText = "delete from sobe where brsobe=0";
                }
                else
                {
                    command.CommandText = "delete from sobe where brsobe=" + roomNumber + "";
                }
                return command.ExecuteNonQuery();

            }
        }

    }
}
