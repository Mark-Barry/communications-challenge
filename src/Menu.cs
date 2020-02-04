using System;
namespace Com_Challenge.src
{
    public static class Menu
    {

        public static string WelcomeFile()
        {
            bool confirm = false;
            string introPath = "";

            Console.WriteLine("Welcome to the Text Based Game Creater\n");
            while (confirm != true)
            {
                Console.WriteLine("Please enter the location of the file to use for the Adventure: ");
                introPath = Console.ReadLine();
                confirm = ConfirmFile(introPath);
            }
            return introPath;
        }
        public static string MapFile()
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
        public static bool ConfirmFile(string link)
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


        public static void StartAdventure()
        {

        }
    }
}
