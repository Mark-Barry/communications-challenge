using System;
using
using Com_Challenge.Classes.Character;

namespace Com_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Player plyr = new Player();
            plyr.name = "bryan";
            plyr.gender = "male";
            plyr.health = "100";
        }
    }
}
