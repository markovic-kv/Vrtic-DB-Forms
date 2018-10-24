using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Rooms //
    {
        private int IdRoom;
        private int RoomNum;
        private string Size;

        public int GetSetIdRoom
        {
            get { return IdRoom; }
            set { IdRoom = value; }
        }
        public int GetSetRoomNum
        {
            get { return RoomNum; }
            set { RoomNum = value; }
        }
        public string GetSetSize
        {
            get { return Size; }
            set { Size = value; }
        }

    }
}
