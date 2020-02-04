
﻿using Com_Challenge.Classes.Character;
using Com_Challenge.src.Menu;
using Com_Challenge.src;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Com_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt user for filepaths
            string adventure_file = "";

            while (true)
            {
                adventure_file = Menu.WelcomeFile();

                if (Menu.ConfirmFile(adventure_file))
                {
                    break;
                }
            }

            // read in data from JSON

            JSONHandler<Adventure>.FileReader(adventure_file);


            // Enter starting room



        }
    }
}



