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

        public string Name { get { return this.GetName(); } set { } }
        public string Gender { get { return this.GetGender(); } set { } }
        public int Health { get { return this.GetHealth(); } set { } }


        public Player(string name, string gender, int health)
        {
            this.name = name;
            this.gender = gender;
            this.health = health;

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
