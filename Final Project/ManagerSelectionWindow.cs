using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class ManagerSelectionWindow : UserControl
    {
        public ManagerSelectionWindow()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            //Returns the user to the login screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            LoginScreen ls = new LoginScreen();
            f.Controls.Add(ls);
        }

        private void priceButton_Click(object sender, EventArgs e)
        {
            //Brings the user to the price selection screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            PriceSelectionWindow psw = new PriceSelectionWindow();
            f.Controls.Add(psw);
        }

        private void warehouseButton_Click(object sender, EventArgs e)
        {
            //Brings the user to the warehouse recievings screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            WarehouseRecievingsWindow wrw = new WarehouseRecievingsWindow();
            f.Controls.Add(wrw);
        }
    }
}
