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
    public partial class LoginScreen : UserControl
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        List<Associate> associates = new List<Associate>();
        List<string> associateList = File.ReadAllLines("associateInfo.txt").ToList();
        List<string> managerList = File.ReadAllLines("managerInfo.txt").ToList();
        private void shutdownButton_Click(object sender, EventArgs e)
        {
           Form f = this.FindForm();
            f.Close();
        }

        private void associateCreateButton_Click(object sender, EventArgs e)
        {
            List<string> tempList = new List<string>();
            if (managerList.Contains(userTextBox.Text) || associateList.Contains(userTextBox.Text))
            {
                MessageBox.Show("Account already exists");
            }
            else
            {
                try
                {
                    string userName = userTextBox.Text;
                    int pin = Convert.ToInt32(pinTextBox.Text);

                    Associate a = new Associate(userName, pin);
                    associateList.Add(Convert.ToString(a));

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
                    string message = "Please use letters for Username and numbers for PIN";
                    MessageBox.Show(message);
                }
            }

            
        }

        private void managerCreateButton_Click(object sender, EventArgs e)
        {          
            List<string> tempList = new List<string>();
            List<Manager> managers = new List<Manager>();

            try
            {
                string managerUserName = userTextBox.Text;
                int managerPin = Convert.ToInt32(pinTextBox.Text);

                Manager m = new Manager(managerUserName, managerPin);
                managerList.Add(Convert.ToString(m));

                string messsage = "Manager account created";
                MessageBox.Show(messsage);
            }
            catch
            {
                string message = "Please use letters for Username and numbers for PIN";
                MessageBox.Show(message);
            }

            foreach (Manager m in managers)
            {
                tempList.Add(m.managerUserName);
                tempList.Add(Convert.ToString(m.managerPin));
            }

            File.WriteAllLines("associateInfo.txt", tempList);
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < associateList.Count; i += 2)
            {
                string userName = associateList[i];
                int pin = Convert.ToInt32(associateList[i + 1]);

                Associate a = new Associate(userName, pin);
                associates.Add(a);
            }

            label6.Text = "";

            foreach (Associate a in associates)
            {
                label6.Text += $"{a.userName} {a.pin}\n";
            }
        }

        private void associateLoginButton_Click(object sender, EventArgs e)
        {
            if (associateList.Contains(userTextBox.Text))
            {
                if (associateList.Contains(pinTextBox.Text))
                {
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
            if (managerList.Contains(userTextBox.Text))
            {
                if (managerList.Contains(pinTextBox.Text))
                {
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
    }
}
