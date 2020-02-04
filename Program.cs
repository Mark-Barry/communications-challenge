
﻿using Com_Challenge.Classes.Character;
using Com_Challenge.src.Menu;
using Com_Challenge.src;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Com_Challenge
{
    class Program
    {
<<<<<<< HEAD
        static void Main(string[] args)
        {
            // prompt user for filepaths
            string adventure_file = "";
=======
        static void Main(string[] args)
        {
            var rooms = new List<Room>();
            PlayerInput input = new PlayerInput();

            //input.directionInput();

            Console.WriteLine("Please, enter a file path and name that contains the Room objects: ");
            rooms = JSONHandler<Room>.FileReader(@"C:\Users\Administrator1\Desktop\challenge\rooms.txt");
            for (int i = 0; i < rooms.Count; i++)
            {
                Console.WriteLine(rooms[i].Name);
            }
>>>>>>> a4615b53132ab0199c4d40d79e0d6994df0a0c62

            while (true)
            {
                adventure_file = Menu.WelcomeFile();

                if (Menu.ConfirmFile(adventure_file))
                {
                    break;
                }
            }

            // read in data from JSON

            JSONHandler<Adventure>.FileReader(adventure_file);


            // Enter starting room



        }
    }
}



