using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RoomsBusiness
    {
        public List<Rooms> AllRooms()
        {
            List<Rooms> lst = new List<Rooms>();
            RoomsRepository ro = new RoomsRepository();
            lst = ro.GetAllRooms();
            var varList = from s in lst orderby s.GetSetRoomNum ascending select s;
            List<Rooms> lst2 = new List<Rooms>();
            foreach (var v in varList)
            {
                lst2.Add(v);
            }
            return lst2;
        }
        public Rooms RoomByRoomNumber(int par)
        {
            RoomsRepository sr = new RoomsRepository();
            List<Rooms> lstRoom = new List<Rooms>();
            lstRoom = AllRooms();
            var varLst = from s in lstRoom where s.GetSetRoomNum == par select s;
            List<Rooms> lst2 = new List<Rooms>();
            foreach (var v in varLst)
            {
                lst2.Add(v);
            }
            return lst2[0];
        }
        public bool RoomExists(int roomNumber)
        {
            bool check = false;
            RoomsRepository ro = new RoomsRepository();
            List<Rooms> lstRoom = new List<Rooms>();
            lstRoom = AllRooms();
            var varLst = from s in lstRoom where s.GetSetRoomNum == roomNumber select s;
            List<Rooms> lst2 = new List<Rooms>();
            foreach (var v in varLst)
            {
                lst2.Add(v);
            }
            if (lst2.Count > 0)
            {
                check = true;
            }
            return check;
        }
        public string InsertRoom(Rooms s)
        {
            int insertNum = 0;
            RoomsRepository ro = new RoomsRepository();
            insertNum = ro.InsertRooms(s);
            if (insertNum > 0)
            {
                return "Ispravan unos";
            }
            else
            {
                return "Neispravan unos";
            }
        }
        public string UpdateRoom(Rooms s)
        {
            int insertNum = 0;
            RoomsRepository sr = new RoomsRepository();
            insertNum = sr.UpdateRooms(s);
            if (insertNum > 0)
            {
                return "Ispravan unos";
            }
            else
            {
                return "Neispravan unos";
            }
        }
        public string DeleteRoom(int id)
        {
            RoomsRepository sr = new RoomsRepository();
            int num = sr.DeleteRoom(id);
            if (num > 0)
            {
                return "Uspesno brisanje";
            }
            else
            {
                return "Neuspesno brisanje";
            }
        }
    }
}
