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
    public partial class PriceSelectionWindow : UserControl
    {
        //Global variables
        List<Item> itemDB = new List<Item>();
        public PriceSelectionWindow()
        {
            InitializeComponent();
            ExtractItem();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //Brings user back to the manager selection screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ManagerSelectionWindow msw = new ManagerSelectionWindow();
            f.Controls.Add(msw);
        }
        public void ExtractItem()
        {
            string newName, newCategory, newPrice, newNumber, newCPrice, newQuantity;
            XmlReader reader = XmlReader.Create("inventoryFile.xml");

            //Reads the item information from the inventory xml file
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

            //Checks to see if item is in inventory xml file and displays it
            if (i != null)
            {
                inventoryOutput.Text = "Item name: " + i.newName + "\n\n"
                    + "Unit price: $" + i.newPrice + "\n\n"
                    + "Customer price: $" + i.newCPrice + "\n\n"
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

        private void setButton_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new System.Xml.XmlDocument();
            doc.Load("inventoryFile.xml");
            int index = itemDB.FindIndex(i => i.newName == inventoryTextBox.Text);

            //Sets the customer price of the selected item
            if (index >= 0)
            {
                itemDB[index].newCPrice = priceInput.Text;
            }
            else
            {
                inventoryTextBox.Text = "";
                priceInput.Value = 0;
                inventoryOutput.Text = "Item not found";
            }
            doc.Save("inventoryFile.xml");
        }
    }
}

