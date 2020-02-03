using System;
using System.Collections.Generic;
using System.Text;
using Com_Challenge.src;

namespace Com_Challenge.Classes.Character
{
    class Player
    {
        public string name;
        public string gender;
        public int health;
        public Inventory inventory;

        public Player(string name, string gender, int health)
        {
            this.name = name;
            this.gender = gender;
            this.health = health;
            inventory = new Inventory();

        }
        //construstor 
        public Player()
        {

        }
        //setters 
        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetGender(string gender)
        {
            this.gender = gender;
        }

        //Getters 
        public string GetName()
        {
            return this.name;
        }

        public string GetGender()
        {
            return this.gender;
        }

        public int GetHealth()
        {
            return this.health;
        }


        public void print()
        {
            Console.WriteLine("character: " + this.name + "/nGender: " + this.gender + "/nHealth: " + health + "./n");
        }
    }
}
