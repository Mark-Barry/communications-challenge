using System;
using System.Collections.Generic;
using Com_Challenge.src;

public class Room
{

    public string Name { get; set; }
    public string Description { get; set; }
    public string Clue { get; set; }
    public string Key { get; set; } 
    public List<Door> DoorList;

    public Room(string name, string description, string clue, string key)
    {
        this.Name = name;
        this.Description = description;
        this.Clue = clue;
        this.Key = key;
        DoorList = new List<Door>();
    }
}
