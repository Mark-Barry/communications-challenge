using System;
using System.Collections.Generic;
using System.Text;

namespace Com_Challenge.src
{
    class MenuHandler
    {
        public void displayMenu()
        {
            string choice = "";
            while(choice != "exit")
            {
                string adventureFile = Menu.WelcomeFile();
                string mapFile = Menu.MapFile();
                Console.WriteLine("Enter 'Exit' to exit: ");
                choice = Console.ReadLine();
            }
        }
    }
}
