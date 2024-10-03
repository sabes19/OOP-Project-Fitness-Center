using System;

namespace OOP_Project_Fitness_Center
{
    public class Club
    {
        private string _name;
        private string _address;
        public string Name
        {
            get { return _name; } 
            set { _name = value; }
        }
        public string Address 
        {
            get { return _address; }
            set { _address = value; }
        }
        public Club(string name, string address)
        {
            _name = name;
            _address = address;
        }
    }
}
