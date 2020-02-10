
using Com_Challenge.Classes.Character;
using Com_Challenge.src;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;

namespace Com_Challenge
{
	class Program
	{
		static void Main(string[] args)
		{

            Console.Title = "Text base game engine";
			//// Enter starting room
			PlayerInput input = new PlayerInput();
			RoomHandler roomHandler = new RoomHandler();
			Player player = new Player();

			var adventures = new List<Adventure>();
			var Rooms = new List<Room>();


			adventures = JSONHandler<Adventure>.FileReader(Menu.WelcomeFile());
			Rooms = roomHandler.GetRooms(Menu.MapFile());


			string location = Rooms[0].RoomID;
            player.currenetLocation = location;
			string previousLocation = "";
            player.previousLocation = previousLocation;

			input.ResetInputList(Rooms[0].RoomID, Rooms);
			Console.Clear();


			Console.Title = adventures[0].Name;
			Console.WriteLine("Welcome to " + adventures[0].Name);
			Menu.WriteChars(adventures[0].Description, 100);
            string previousRoomName = "";

            while (location != "exit")
			{
				for (int i = 0; i < Rooms.Count; i++)
				{
					if (Rooms[i].RoomID == location)
					{
						Menu.WriteChars(Rooms[i].Description, 100);
                        previousRoomName = Rooms[i].Name;
                    }
                    
                }
                Console.WriteLine("You are currently in: " + previousRoomName);
                input.ResetInputList(location, Rooms);
				previousLocation = location;
				location = input.directionInput(Rooms);
				Console.Clear();
                if (location == adventures[0].WinningRoomId)
                {
                    Console.WriteLine("Congratulations! You won!");
                    break;
                }
				Console.WriteLine("You just came from: " + previousRoomName);
			}
		}
	}
}



