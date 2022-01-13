using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Manager
    {
        public string managerUserName;
        public int managerPin;

        public Manager(string _managerUserName, int _managerPin)
        {
            managerUserName = _managerUserName;
            managerPin = _managerPin;
        }
    }
}
