using System;
using System.Collection.Generics;
using System.Text;


public class Room
{
    private string name;
    private string description;
    private List<string> exitList;
    private string roomID;

    public string Name { get { return this.GetName(); } set { this.SetName(Name); } }
    public string Description { get { return this.GetDescription(); } set { this.SetDescription(Description); } }
    public List<string> ExitList { get { return this.GetExitList(); } set { this.SetExitList(ExitList); } }
    public string RoomID { get { return this.GetRoomID(); } set { this.SetRoomID(RoomID); } }

    public Room(string name, string description, List<string> exitList)
    {
        this.name = name;
        this.description = description;
        this.exitList = new List<string>();
        this.exitList = exitList;
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

    public void SetExitList(List<string> exitList)
    {
        this.exitList = exitList;
    }
    
    public void SetRoomID(string roomID)
    {
        this.roomID = roomID;
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

    public List<string> GetExitList()
    {
        return this.exitList;
    }

    public string GetRoomID()
    {
        return this.roomID;
    }




}
