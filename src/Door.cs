using System;
using System.Collections.Generic;
using System.Text;

namespace Com_Challenge.src
{
    class Door
    {
        private bool isLocked;
        private string key;

        public Door(bool isLocked, string key)
        {
            this.isLocked = isLocked;
            this.key = key;
        }
        public Door()
        {
            this.isLocked = false;
            this.key = "";
        }

        public bool getIsLocked()
        {
            return this.isLocked;
        }
        public void setIsLocked(bool isLocked)
        {
            this.isLocked = isLocked;
        }
        public string getKey()
        {
            return this.key;
        }
        public void setKey(string key)
        {
            this.key = key;
        }
    }
}
