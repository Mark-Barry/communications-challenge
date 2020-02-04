using System;
using System.Collections.Generic;
using System.Text;

namespace Com_Challenge.src
{
    class Weapon
    {
        private string name;
        private int damage;

        public Weapon(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }

        public Weapon()
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

        public string GetName()
        {
            return this.name;
        }

        public int GetDamage()
        {
            return this.damage;
        }

        public void print()
        {
            Console.WriteLine("Weapon: " + this.name + "/ndamage: " + this.damage);
        }
    }


}
