using System;
using System.Collections.Generic;
using System.Timers;
namespace Com_Challenge.src
{
	public class Menu
	{
		List<string> commandList = new List<string>();

		/// <summary>
		/// Asks the user to input the Adventure file and then verifies that it is the correct path with the user
		/// </summary>
		/// <returns>a string representative of the file path</returns>
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
		/// <summary>
		/// Asks the user to input the Map file and then verifies that it is the correct path with the user
		/// </summary>
		/// <returns>a string representative of the file path</returns>
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
		/// <summary>
		/// Asks the user to confirm that the input path is the correct path
		/// </summary>
		/// <param name="link">a file path to confirm</param>
		/// <returns>a boolean represneting if the file path is correct(true) or not(false)</returns>
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
		/// <summary>
		/// Takes a string and outputs it one character at a time
		/// </summary>
		/// <param name="input">A string to be displayed one character at a time</param>
		/// <param name="waitTime">The time to wait between displaying characters.</param>
		public static void WriteChars(string input, int waitTime)
		{
			Timer wait = new Timer(waitTime);
			for (int i = 0; i <= input.Length - 1; i++)
			{
				Console.Write(input[i]);
				System.Threading.Thread.Sleep(100);
			}
			Console.WriteLine("\n");
		}


		public static void StartAdventure()
		{

		}
	}
}
