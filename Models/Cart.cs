using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TFLStore.Models
{
    public class Cart
    {
        private List<Item> items = new List<Item>();
        public bool AddToCart( Item item)
        {
            bool status = false;
            items.Add(item);
            status = true;
            return status;
        }
        public List<Item> GetAllItems()
        {
            return items;
        }    
        public bool RemoveFromCart(Item item)
        {
            bool status = false;
            items.Remove(item);
            status = true;
            return status;
        }
    }
}