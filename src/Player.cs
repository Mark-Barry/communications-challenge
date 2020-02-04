using System;
using System.Collections.Generic;
using System.Text;

namespace Com_Challenge.Classes.Character
{
    class Player
    {
        private string name;
        private string gender;
        private int health;
        private Inventory inventory;
        

        public string Name { get { return this.GetName(); } set { this.SetName(Name); } }
        public string Gender { get { return this.GetGender(); } set { this.SetGender(Gender); } }
        public int Health { get { return this.GetHealth(); } set { this.SetHealth(Health); } }


        public Player(string name, string gender, int health, Inventory inventory)
        {
            this.name = name;
            this.gender = gender;
            this.health = health;
            this.inventory = inventory;
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

        public void SetHealth()
        {
            this.health = health;
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
