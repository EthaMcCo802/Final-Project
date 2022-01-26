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
using System.IO;

namespace Final_Project
{
    public partial class WarehouseRecievingsWindow : UserControl
    {
        List<Warehouse> warehouseDB = new List<Warehouse>();
        List<Item> itemDB = new List<Item>();
        public WarehouseRecievingsWindow()
        {
            InitializeComponent();
            ExtractItem();
        }

        public void ExtractItem()
        {
            string newName, newCategory, newPrice, newNumber, newQuantity, newCPrice;
            XmlReader reader = XmlReader.Create("warehouseInventory.xml");

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

                    Warehouse w = new Warehouse(newName, newPrice, newCPrice, newQuantity, newCategory, newNumber);
                    warehouseDB.Add(w);
                }
            }
            reader.Close();
        }

        public void WriteInventory()
        {
            XmlWriter writer = XmlWriter.Create("inventoryFile.xml");

            writer.WriteStartElement("Inventory");
            foreach (Warehouse w in warehouseDB)
            {
                writer.WriteStartElement("Item");

                writer.WriteElementString("Name", w.newName);
                writer.WriteElementString("Price", w.newPrice);
                writer.WriteElementString("CPrice", w.newCPrice);
                writer.WriteElementString("Quantity", w.newQuantity);
                writer.WriteElementString("Category", w.newCategory);
                writer.WriteElementString("Number", w.newNumber);

                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.Close();
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            Warehouse w = warehouseDB.Find(warehouse => warehouse.newName == warehouseInventoryInput.Text || warehouse.newNumber == warehouseInventoryInput.Text);

            if (w != null)
            {
                warehouseInventoryOutput.Text = "Item name: " + w.newName + "\n\n"
                    + "Unit price: $" + w.newPrice + "\n\n"
                    + "Category: " + w.newCategory + "";
            }
            else
            {
                warehouseInventoryInput.Text = "";
                warehouseInventoryOutput.Text = "Item does not exist";
                return;
            }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {

            int index = warehouseDB.FindIndex(w => w.newName == warehouseInventoryInput.Text);
            int itemIndex = itemDB.FindIndex(i => i.newQuantity == Convert.ToString(QuantityInput.Value));
            if (index >= 0)
            {
                warehouseDB[index].newQuantity = Convert.ToString(QuantityInput.Value);

                WriteInventory();

            }
            else
            {
                warehouseInventoryInput.Text = "";
                warehouseInventoryOutput.Text = "Item not found";
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ManagerSelectionWindow msw = new ManagerSelectionWindow();
            f.Controls.Add(msw);
        }
    }
}
