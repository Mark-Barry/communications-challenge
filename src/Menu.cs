﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Com_Challenge.src
{
    class Menu
    {

        public string WelcomeFile()
        {
            bool confirm = false;
            string introPath = "";

            Console.WriteLine("Welcome to the Text Based Game Creater\n");
            while (confirm != true)
            {
                Console.WriteLine("Please enter the location of the file to use for the introduction: ");
                introPath = Console.ReadLine();
                confirm = ConfirmFile (introPath);
            }
            return introPath;
        }
        public string PlayerFile()
        {
            bool confirm = false;
            string playerPath = "";

            while (confirm != true)
            {
                Console.WriteLine("Please choose the file you want to use for your character: ");
                playerPath = Console.ReadLine();
                confirm = ConfirmFile(playerPath);
            }
            return playerPath;
        }
        public string MapFile()
        {
            bool confirm = false;
            string mapPath = "";

            while (confirm != true)
            {
                Console.WriteLine("Please choose the file you want to use for the map: ");
                mapPath = Console.ReadLine();
                confirm = ConfirmFile(mapPath);
            }
            return mapPath;
        }
        public bool ConfirmFile(string link)
        {
            string decision = "";
            while (decision != "yes" || decision != "no")
            {
                Console.WriteLine("are you sure that " + link + " is correct? yes/no");
                decision = Console.ReadLine().ToLower();
                if (decision == "yes")
                {
                    return true;
                }
                else if (decision == "no")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine(decision + " is not a recognised command. Please enter yes or no.");
                }
            }
            return false;
        }
    }
}
