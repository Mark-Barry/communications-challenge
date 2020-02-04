using System;
using System.Collections.Generic;
using System.Text;

namespace Com_Challenge.src
{
    class Monster
    {
        private string name;
        public string Name { get { return this.GetName(); } }
        private int damage;
        public int Damage { get { return this.GetDamage(); } }
        private int health;
        public int Health { get { return this.GetHealth(); } }

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
