using System;
using System.Collections.Generic;

namespace Com_Challenge.src
{
    public class Inventory
    {
        public List<Item> items;

        public Inventory()
        {
            items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void Remove(Item item)
        {
            items.Remove(item);
        }

        public void Remove(int index)
        {
            items.RemoveAt(index);
        }
    }
}
