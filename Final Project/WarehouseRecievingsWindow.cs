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
    public partial class WarehouseRecievingsWindow : UserControl
    {
        List<Warehouse> warehouseDB = new List<Warehouse>();
        public WarehouseRecievingsWindow()
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
            string newName, newCategory, newPrice, newNumber;
            XmlReader reader = XmlReader.Create("warehouseInventory.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    newName = reader.ReadString();

                    reader.ReadToNextSibling("Price");
                    newPrice = reader.ReadString();

                    reader.ReadToNextSibling("Category");
                    newCategory = reader.ReadString();

                    reader.ReadToNextSibling("Number");
                    newNumber = reader.ReadString();

                    Warehouse w = new Warehouse(newName, newPrice, newCategory, newNumber);
                    warehouseDB.Add(w);
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Warehouse w = warehouseDB.Find(warehouse => warehouse.newName == warehouseInventoryInput.Text || warehouse.newNumber == warehouseInventoryInput.Text);

            ExtractItem();

            if (w != null)
            {
                warehouseInventoryOutput.Text = "Item name: " + w.newName + "\n\n"
                    + "Unit price: $" + w.newPrice + "\n\n"
                    + "Category: " + w.newCategory + "\n\n"
                    + "Number: " + w.newNumber + "";
            }
            else
            {
                warehouseInventoryInput.Text = "";
                warehouseInventoryOutput.Text = "Item does not exist";
                return;
            }
        }
    }
}
