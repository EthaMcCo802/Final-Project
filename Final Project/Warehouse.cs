using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class Warehouse
    {
        public string newName, newCategory, newPrice, newNumber;

        public Warehouse(string _newName, string _newPrice, string _newCategory, string _newNumber)
        {
            newName = _newName;
            newPrice = _newPrice;
            newCategory = _newCategory;
            newNumber = _newNumber;
        }
    }
}
