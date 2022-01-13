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
        List<Manager> managers = new List<Manager>();

        private void shutdownButton_Click(object sender, EventArgs e)
        {
           Form f = this.FindForm();
            f.Close();
        }

        private void associateCreateButton_Click(object sender, EventArgs e)
        {
            List<string> associateList = File.ReadAllLines("associateInfo.txt").ToList();
            List<string> tempList = new List<string>();

            try
            {
                string userName = userTextBox.Text;
                int pin = Convert.ToInt32(pinTextBox.Text);

                Associate a = new Associate(userName, pin);
                associateList.Add(Convert.ToString(a));

                string messsage = "Associate account created";
                MessageBox.Show(messsage);
            }
            catch
            {
                string message = "Please use letters for Username and numbers for PIN";
                MessageBox.Show(message);
            }

            foreach (Associate a in associates)
            {
                tempList.Add(a.userName);
                tempList.Add(Convert.ToString(a.pin));
            }

            File.WriteAllLines("associateInfo.txt", tempList);
        }

        private void managerCreateButton_Click(object sender, EventArgs e)
        {
            List<string> managerList = File.ReadAllLines("managerInfo.txt").ToList();
            List<string> tempList = new List<string>();

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
    }
}
