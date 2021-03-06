using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Final_Project
{
    public partial class InventoryLookupScreen : UserControl
    {
        //Global variables
        List<Item> itemDB = new List<Item>();
        public InventoryLookupScreen()
        {
            InitializeComponent();
            ExtractItem();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            //Returns the user to the login screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            LoginScreen ls = new LoginScreen();
            f.Controls.Add(ls);
        }

        public void ExtractItem()
        {
            string newName, newCategory, newPrice, newNumber, newCPrice, newQuantity;
            XmlReader reader = XmlReader.Create("inventoryFile.xml");


            //Extracts the item information from the xml file
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    newName = reader.ReadString();

                    reader.ReadToNextSibling("Price");
                    newPrice = reader.ReadString();

                    reader.ReadToNextSibling("CPrice");
                    newCPrice = reader.ReadString();

                    reader.ReadToNextSibling("Quantity");
                    newQuantity = reader.ReadString();

                    reader.ReadToNextSibling("Category");
                    newCategory = reader.ReadString();

                    reader.ReadToNextSibling("Number");
                    newNumber = reader.ReadString();

                    Item i = new Item(newName, newPrice, newCPrice, newQuantity, newCategory, newNumber);
                    itemDB.Add(i);
                }
            }
            reader.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Item i = itemDB.Find(item => item.newName == inventoryTextBox.Text || item.newNumber == inventoryTextBox.Text);

            //Searchs the xml for the searched item and displays it
            if (i != null)
            {
                inventoryTextBox.Text = "";
                inventoryOutput.Text = "Item name: " + i.newName + "\n\n"
                    + "Price: $" + i.newCPrice + "\n\n"
                    + "Quantity: " + i.newQuantity + "\n\n"
                    + "Category: " + i.newCategory + "\n\n"
                    + "Number: " + i.newNumber + "";
            }
            else
            {
                inventoryTextBox.Text = "";
                inventoryOutput.Text = "Item does not exist";
                return;
            }
        }
    }
}
