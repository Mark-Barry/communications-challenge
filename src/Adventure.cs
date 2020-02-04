using System;
using System.Collections.Generic;
using System.Text;

namespace Com_Challenge.src
{
    public class Adventure
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string  Description { get; set; }
        public List<String> RoomIds { get; set; }
    }
}
