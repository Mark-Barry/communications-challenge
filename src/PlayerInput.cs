using System;
using System.Collections.Generic;
using System.Text;

namespace Com_Challenge.src
{
    class PlayerInput
    {
        List<string> InputList = new List<string>();

        public void ResetInputList(string roomId, List<Room> rooms)
        {
            foreach (var room in rooms)
            {
                if (room.GetRoomID() == roomId)
                {
                    InputList = room.GetExitList();
					//InputList.Add("help");
					//InputList.Add("search");
					//InputList.Add("inventory");
					//InputList.Add("exit");
                    break;
                }
            }
        }

        public string directionInput(List<Room> rooms)
        {
            Console.Write("Exit options:");
            foreach (var option in InputList)
            {
                Console.Write(" "+option);
            }
            Console.WriteLine();
            Console.Write("Enter a Direction or exit:");
            string direction = Console.ReadLine();
            direction.ToLower();

            while (!InputList.Contains(direction) && direction != "exit")
            {
                Console.WriteLine("Incorrect input! Please, try again!");
                Console.WriteLine("Enter a Direction or exit:");
                direction = Console.ReadLine();
            }
            return direction;
        }
    }
}   

