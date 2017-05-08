using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Item
    {
        public string name;
        public int quantity, id;

        /// <summary>
        /// Default constructor for our items, in case something goes wrong.
        /// </summary>
        public Item()
        {
            this.name = "unknown";
            this.quantity = 0;
            this.id = 0;
        }

        /// <summary>
        /// Constructor for items that takes a name, quantity, and ID.
        /// </summary>
        /// <param name="name">The name of the item</param>
        /// <param name="quantity">The amount of the items</param>
        /// <param name="id">The ID of the item</param>
        public Item(string name, int quantity, int id)
        {
            this.name = name;
            this.quantity = quantity;
            this.id = id;
        }

        /// <summary>
        /// Set the name of the item
        /// </summary>
        /// <param name="name">Name of the item</param>
        public void SetName(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Set the quantity of the item.
        /// </summary>
        /// <param name="amount">The amount of the item</param>
        public void SetQuantity(int amount)
        {
            this.quantity = amount;
        }

        /// <summary>
        /// Set the ID of the item
        /// </summary>
        /// <param name="id">The ID of the item</param>
        public void SetID(int id)
        {
            this.id = id;
        }
    }
}
