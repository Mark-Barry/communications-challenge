using System;
using System.Collections.Generic;
using System.Text;

namespace Com_Challenge.src
{
    class PlayerInput
    {
        bool myBool = false;
        string[] inputs = { "north", "south", "east", "west", "n", "s", "e", "w" };
        List<string> InputList = new List<string> { "north", "south", "east", "west", "n", "s", "e", "w" };


        public void directionInput()
        {
            Console.WriteLine("Enter a Direction");
            string direction = Console.ReadLine();
            direction.ToLower();
            foreach (string element in InputList)
            {
                myBool = element == direction;
                if (myBool)
                    break;
            }

            if (myBool)
                Console.Write("In array");
            else
                Console.Write("Not in array");
                Console.ReadLine();

        }

        //static void Main(string[] args)
        //{
        //    PlayerInput input = new PlayerInput();
        //    input.directionInput();
        //}

    }
}   

