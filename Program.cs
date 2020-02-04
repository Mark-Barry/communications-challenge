
﻿using Com_Challenge.Classes.Character;
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
            //var rooms = new List<Room>();
            //PlayerInput input = new PlayerInput();

            ////input.directionInput();

            //Console.WriteLine("Please, enter a file path and name that contains the Room objects: ");
            //rooms = JSONHandler<Room>.FileReader(@"C:\Users\Administrator1\Desktop\challenge\rooms.txt");
            //for (int i = 0; i < rooms.Count; i++)
            //{
            //    Console.WriteLine(rooms[i].Name);
            //}
            //string adventure_file;
            //while (true)
            //{
            //    adventure_file = Menu.WelcomeFile();

            //    if (Menu.ConfirmFile(adventure_file))
            //    {
            //        break;
            //    }
            //}

            //// read in data from JSON

            //JSONHandler<Adventure>.FileReader(adventure_file);


            //// Enter starting room
            var adventures = new List<Adventure>();
            var Rooms = new List<Room>();
            RoomHandler roomHandler = new RoomHandler();
            Rooms = roomHandler.GetRooms(Menu.MapFile());
            Console.WriteLine(Rooms.Count);

            Player player = new Player();
            string location = player.currenetLocation;
            location = Rooms[0].roomID;
            string previousLocation = player.previousLocation;
            previousLocation = "";
            PlayerInput input = new PlayerInput();
            input.ResetInputList(Rooms[0].roomID, Rooms);
            while (location != "exit")
            {
                Console.WriteLine("You are currently in: " + location);
                for (int i = 0; i < Rooms.Count; i++)
                {
                    if (Rooms[i].roomID == location)
                    {
                        Console.WriteLine(Rooms[i].description);
                    }
                }
                input.ResetInputList(location, Rooms);
                previousLocation = location;
                location = input.directionInput();
                Console.Clear();
                Console.WriteLine("You just came from: " + previousLocation);

            }
            //MenuHandler menuHandler = new MenuHandler();
            //menuHandler.displayMenu();
        }
    }
}



