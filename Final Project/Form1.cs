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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LoginScreen ls = new LoginScreen();
            //this.Controls.Add(ls);
            InventoryLookupScreen ils = new InventoryLookupScreen();
            this.Controls.Add(ils);
        }
    }
}
