using System;
using System.Collection.Generics;
using System.Text;


public class Room
{
    private string name;
    private string description;
    private List<Room> ExitList;
    private string roomID;

    public Room(string name, string description, List<Door> doorsList)
    {
        this.name = name;
        this.description = description;
        this.ExitList = new List<Room>();
        this.ExitList = ExitList;
    }
    //construter
    public Room()
	{
	}
    //setters 
    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetDescription(string description)
    {
        this.description = description;
    }
    
    //getters
    public string GetName()
    {
        return this.name;
    }

    public string GetDescription()
    {
        return this.description;
    }






}
