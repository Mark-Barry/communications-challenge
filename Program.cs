
using Com_Challenge.Classes.Character;
using Com_Challenge.src;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Com_Challenge
{
	class Program
	{
		static void Main(string[] args)
		{
			//// Enter starting room
			PlayerInput input = new PlayerInput();
			RoomHandler roomHandler = new RoomHandler();
			Player player = new Player();

			var adventures = new List<Adventure>();
			var Rooms = new List<Room>();


			adventures = JSONHandler<Adventure>.FileReader(Menu.WelcomeFile());
			Rooms = roomHandler.GetRooms(Menu.MapFile());


			string location = player.currenetLocation;
			location = Rooms[0].roomID;
			string previousLocation = player.previousLocation;
			previousLocation = "";

			input.ResetInputList(Rooms[0].roomID, Rooms);
			Console.Clear();


			Console.Title = adventures[0].Name;
			Console.WriteLine("Welcome to " + adventures[0].Name);
			Menu.WriteChars(adventures[0].Description, 100);
			while (location != "exit")
			{
				for (int i = 0; i < Rooms.Count; i++)
				{
					if (Rooms[i].roomID == location)
					{
						Menu.WriteChars(Rooms[i].description, 100);
					}
				}
				Console.WriteLine("You are currently in: " + location);
				input.ResetInputList(location, Rooms);
				previousLocation = location;
				location = input.directionInput();
				Console.Clear();
				Console.WriteLine("You just came from: " + previousLocation);
			}
		}
	}
}



