using System;
using System.Collections.Generic;
using System.Text;

namespace Com_Challenge.src
{
    public class RoomHandler
    {
        public List<Room> GetRooms(string filename)
        {
            var rooms = new List<Room>();
            rooms = JSONHandler<Room>.FileReader(filename);
            return rooms;
        }
    }
}
