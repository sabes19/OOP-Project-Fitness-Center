using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Fitness_Center
{
    public class Club
    {
        private Dictionary<string, string> _clubs;

        public Dictionary<string,string> Clubs
        {
            get {  return _clubs; }
            set { _clubs = value; }
        }
        public Club()
        {
            Clubs = new Dictionary<string, string>
            {
                { "Fitness Center 1", "Denver,CO" },
                { "Fitness Center 2", "Pittsburgh,PA" },
                { "Fitness Center 3", "Detroit,MI" },
                { "Fitness Center 4", "Chicago,IL" }
            };
        }
        public void AddMember(string name, string address)
        {
                _clubs.Add(name, address);
        }
        public void RemoveMember(string name)
        {
            try
            {
                _clubs.Remove(name);
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Sorry but that member doesn't exist");
                Console.WriteLine("Please enter a valid member name.");
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
