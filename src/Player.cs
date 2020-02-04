using System;
using System.Collections.Generic;
using System.Text;
using Com_Challenge.src;

namespace Com_Challenge.Classes.Character
{
    class Player
    {   //verriables
        private string name;
        private string gender;
        private int health;
        private Inventory inventory;
        private string currenetLocation;
        private string previousLocation;

        //properties so jason can access the verriables 
        public string Name { get { return this.GetName(); } set { this.SetName(Name); } }
        public string Gender { get { return this.GetGender(); } set { this.SetGender(Gender); } }
        public int Health { get { return this.GetHealth(); } set { this.SetHealth(Health); } }
        public string CurrentLocation { get { return this.GetCurrenetLocation(); } set { this.SetCurrenetLocation(CurrentLocation); } }
        public string PreviousLocation { get { return this.GetPreviousLocation(); } set { this.SetPreviousLocation(PreviousLocation); } }

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

        public void SetHealth(int health)
        {
            this.health = health;
        }
        public void SetCurrenetLocation(string currenetLocation)
        {
            this.currenetLocation = currenetLocation;
        }

        public void SetPreviousLocation(string previousLocation)
        {
            this.previousLocation = previousLocation;
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

        public string GetCurrenetLocation()
        {
            return this.currenetLocation;
        }

        public string GetPreviousLocation()
        {
            return this.previousLocation;
        }

        //print method for tesing 
        public void print()
        {
            Console.WriteLine("character: " + this.name + "/nGender: " + this.gender + "/nHealth: " + health + "./n");
        }
    }
}
