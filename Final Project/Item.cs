using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class Item
    {
        public string newName, newCategory, newCPrice, newPrice, newNumber, newQuantity;

        public Item(string _newName, string _newPrice, string _newCPrice, string _newQuantity, string _newCategory, string _newNumber)
        {
            newName = _newName;
            newPrice = _newPrice;
            newCPrice = _newCPrice;
            newQuantity = _newQuantity;
            newCategory = _newCategory;
            newNumber = _newNumber;
        }
    }
}
