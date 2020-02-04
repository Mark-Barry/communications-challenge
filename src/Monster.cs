using System;
using System.Collections.Generic;
using System.Text;

namespace Com_Challenge.src
{
    class Monster
    {
        private string name;
        private int damage;
        private int health;
        public string Name { get { return this.GetName(); } set { this.SetName(Name); } }
        
        public int Damage { get { return this.GetDamage(); } set { this.SetDamage(Damage); } }
        
        public int Health { get { return this.GetHealth(); } set { this.SetHealth(Health); } }

        public Monster(string name, int damage, int health)
        {
            this.name = name;
            this.damage = damage;
            this.health = health;
        }

        public Monster()
        {
          
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetDamage(int damage)
        {
            this.damage = damage;
        }

        public void SetHealth(int health)
        {
            this.health = health;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetDamage()
        {
            return this.damage;
        }

        public int GetHealth()
        {
            return this.health;
        }

        public void print()
        {
            Console.WriteLine("Monster: " + this.name + "/ndamage: " + this.damage + "/nHealth: " + health + "./n");
        }
    }
}
