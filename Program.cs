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
            PlayerInput input = new PlayerInput();

            Console.WriteLine("Please, enter a file path and name that contains the Room objects: ");
            string roomsFileName = "@" + Console.ReadLine();
            rooms = JSONHandler<Room>.FileReader(roomsFileName);
            for (int i = 0; i < rooms.Count; i++)
            {
                Console.WriteLine(rooms[i].Name);
                input.directionInput();
            }

            string filename = @"C:\Users\Administrator1\Desktop\challenge\players.txt";
            var players = new List<Player>();
            Player player1 = new Player();
            player1.SetName("Player1");
            Player player2 = new Player();
            player2.SetName("Player2");
            players.Add(player1);
            players.Add(player2);
            JSONHandler<Player>.FileWriter(filename,players);

            var readPlayers = new List<Player>();
            readPlayers = JSONHandler<Player>.FileReader(filename);
            for (int i = 0; i < readPlayers.Count; i++)
            {
                Console.WriteLine(readPlayers[i].GetName());
            }
        }
    }
}
