using System;
using Com_Challenge.Classes.Character;
using Com_Challenge.src;

namespace Com_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Player plyr = new Player
            {
                name = "bryan",
                gender = "male",
                health = 100
            };

            JSONHandler.FileWriter("test.json", plyr);
        }
    }
}
