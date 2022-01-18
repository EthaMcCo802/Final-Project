using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class Item
    {
        public string newName, newCategory;
        public int newPrice, newNumber;

        public Item(string _newName, int _newPrice, string _newCategory, int _newNumber)
        {
            newName = _newName;
            newPrice = _newPrice;
            newCategory = _newCategory;
            newNumber = _newNumber;
        }
    }
}
