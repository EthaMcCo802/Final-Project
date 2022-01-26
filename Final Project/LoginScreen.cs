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
//Inventory management system
//Mr. T
//Ethan McComb
//An inventory system that allows a business to control and maintain its stock as well as the price of items
namespace Final_Project
{
    public partial class LoginScreen : UserControl
    {
        //Global variables
        List<Associate> associates = new List<Associate>();
        List<Manager> managers = new List<Manager>();


        public LoginScreen()
        {
            InitializeComponent();
            LoadPeople();
        }

        //Loads the login information from an xml file
        public void LoadPeople()
        {
            List<string> associateList = File.ReadAllLines("associateInfo.txt").ToList();
            List<string> managerList = File.ReadAllLines("managerInfo.txt").ToList();

            for (int i = 0; i < associateList.Count; i += 2)
            {
                string userName = associateList[i];
                int pin = Convert.ToInt32(associateList[i + 1]);

                Associate a = new Associate(userName, pin);
                associates.Add(a);
            }

            for (int i = 0; i < managerList.Count; i += 2)
            {
                string userName = managerList[i];
                int pin = Convert.ToInt32(managerList[i + 1]);

                Manager m = new Manager(userName, pin);
                managers.Add(m);
            }
        }


        private void shutdownButton_Click(object sender, EventArgs e)
        {
            //Shuts down the program
            Form f = this.FindForm();
            f.Close();
        }

        private void associateCreateButton_Click(object sender, EventArgs e)
        {
            List<string> tempList = new List<string>();
            int aIndex = associates.FindIndex(a => a.userName == $"{userTextBox.Text}");
            int mIndex = managers.FindIndex(m => m.managerUserName == $"{userTextBox.Text}");

            //Checks to see if the account is already in the xml file
            if (mIndex >= 0 || aIndex >= 0)
            {
                MessageBox.Show("Account already created");
            }
            else
            {
                try
                {
                    //Saves associate login information to a xml file
                    string userName = userTextBox.Text;
                    int pin = Convert.ToInt32(pinTextBox.Text);

                    Associate a = new Associate(userName, pin);
                    associates.Add(a);

                    MessageBox.Show("Associate account created");


                    foreach (Associate associate in associates)
                    {
                        tempList.Add(associate.userName);
                        tempList.Add(Convert.ToString(associate.pin));
                    }

                    File.WriteAllLines("associateInfo.txt", tempList);
                }
                catch
                {
                    MessageBox.Show("Please use letters for Username and numbers for PIN");
                }
            }
        }

        private void managerCreateButton_Click(object sender, EventArgs e)
        {
            List<string> tempList = new List<string>();
            int aIndex = associates.FindIndex(a => a.userName == userTextBox.Text);
            int mIndex = managers.FindIndex(m => m.managerUserName == userTextBox.Text);

            //Checks to see if the account is already in the xml file
            if (mIndex >= 0 || aIndex >= 0)
            {
                MessageBox.Show("Account already created");
            }
            else
            {
                //Saves manager login information to a xml file
                try
                {
                    string managerUserName = userTextBox.Text;
                    int managerPin = Convert.ToInt32(pinTextBox.Text);

                    Manager m = new Manager(managerUserName, managerPin);
                    managers.Add(m);

                    foreach (Manager manager in managers)
                    {
                        tempList.Add(manager.managerUserName);
                        tempList.Add(Convert.ToString(manager.managerPin));
                    }

                    MessageBox.Show("Manager account created");

                    File.WriteAllLines("managerInfo.txt", tempList);
                }
                catch
                {
                    MessageBox.Show("Please use letters for Username and numbers for PIN");
                }
            }
        }

        private void associateLoginButton_Click(object sender, EventArgs e)
        {
            int index = associates.FindIndex(a => a.userName == userTextBox.Text);
            //Checks to see if the inputted information is stored in the xml file
            if (index >= 0)
            {
                if (associates[index].pin == Convert.ToInt32(pinTextBox.Text))
                {
                    //Brings the user to the associate screen
                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    InventoryLookupScreen ils = new InventoryLookupScreen();
                    f.Controls.Add(ils);
                }
                else
                {
                    MessageBox.Show("Incorrect PIN");
                }
            }
            else
            {
                MessageBox.Show("Account not found");
            }


        }

        private void managerLoginButton_Click(object sender, EventArgs e)
        {
            int index = managers.FindIndex(m => m.managerUserName == userTextBox.Text);
            //Checks to see if the inputted information is stored in the xml file
            if (index >= 0)
            {
                if (managers[index].managerPin == Convert.ToInt32(pinTextBox.Text))
                {
                    //Brings the user to the manager selection screen
                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    ManagerSelectionWindow msw = new ManagerSelectionWindow();
                    f.Controls.Add(msw);
                }
                else
                {
                    MessageBox.Show("Incorrect PIN");
                }
            }
            else
            {
                MessageBox.Show("Account not found");
            }
        }
    }
}
