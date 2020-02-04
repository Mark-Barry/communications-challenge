using Com_Challenge.Classes.Character;
using Com_Challenge.src;
using System;
using System.Collections.Generic;

namespace Com_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var rooms = new List<Room>();

            Console.WriteLine("Please, enter a file path and name that contains the Room objects: ");
            rooms = JSONHandler<Room>.FileReader(@"C:\Users\Administrator1\Desktop\challenge\rooms.txt");
            for (int i = 0; i < rooms.Count; i++)
            {
                Console.WriteLine(rooms[i].Name);
            }

            string filename = @"C:\Users\Administrator1\Desktop\challenge\players1.txt";
            //var players = new List<Player>();
            //Player player1 = new Player();
            //player1.SetName("Player1");
            //Player player2 = new Player();
            //player2.SetName("Player2");
            //players.Add(player1);
            //players.Add(player2);
            //JSONHandler<Player>.FileWriter(filename,players);

            var readAdventures = new List<Adventure>();
            readAdventures = JSONHandler<Adventure>.FileReader(filename);
            for (int i = 0; i < readAdventures.Count; i++)
            {
                Console.WriteLine(readAdventures[i].Name);
                Console.WriteLine(readAdventures[i].Description);
                for (int j = 0; j < readAdventures[i].RoomIds.Count; j++)
                {
                    Console.WriteLine(readAdventures[i].RoomIds[j]);
                }
            }
        }
    }
}
