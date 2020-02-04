using System;
using System.Collections.Generic;
using Com_Challenge.src;

public class Room
{

    public string Name { get; set; }
    public string Description { get; set; }
    public List<Door> DoorList;

    public Room(string name, string description)
    {
        this.Name = name;
        this.Description = description;
        DoorList = new List<Door>();
    }
}
