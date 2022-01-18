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
        List<Item> itemDB = new List<Item>();
        public InventoryLookupScreen()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            LoginScreen ls = new LoginScreen();
            f.Controls.Add(ls);
        }

        public void ExtractItem()
        {
            string newName, newCategory;
            int newPrice, newNumber;
            XmlReader reader = XmlReader.Create("Resources/inventoryFile.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    newName = reader.ReadElementContentAsString();

                    reader.ReadToNextSibling("Price");
                    newPrice = reader.ReadElementContentAsInt();

                    reader.ReadToNextSibling("Category");
                    newCategory = reader.ReadElementContentAsString();

                    reader.ReadToNextSibling("Number");
                    newNumber = reader.ReadElementContentAsInt();

                    Item i = new Item(newName, newPrice, newCategory, newNumber);
                    itemDB.Add(i);
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Item i = itemDB.Find(item => item.newName == inventoryTextBox.Text);

            ExtractItem();

            if (i != null)
            {
                DisplayItem();
            }
            else
            {
                MessageBox.Show("Item does not exist");
                return;
            }
        }

        public void DisplayItem()
        {
            inventoryOutput.Text = "";

            foreach (Item i in itemDB)
            {
                inventoryOutput.Text = i.newName + "\n"
                    + i.newPrice + "\n"
                    + i.newCategory + "\n"
                    + i.newNumber + "";

            }
        }
    }
}
