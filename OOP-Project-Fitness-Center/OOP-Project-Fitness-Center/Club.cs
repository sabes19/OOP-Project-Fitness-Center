﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Fitness_Center
{
    public class Club
    {
        private static List<Members> _clubMembers = new List<Members>();

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
        public Club()
        {
            _name = Name;
            _address = Address;
        }
        public static (int,string) GetMemberInfo()
        {
            Random rnd = new Random();
            string? memberName = string.Empty;
            do
            {
                Console.Write("Please enter the new members name: ");
                memberName = Console.ReadLine();
            } while (String.IsNullOrEmpty(memberName));

            return (rnd.Next(10000, 100000), memberName);
        }
        public static void AddMember(Members member)
        {
            _clubMembers.Add(member);
        }
        public static void RemoveMember(Members member)
        {
            _clubMembers.Remove(member);
        }

        public string GetName()
        {
            return _name;
        }
        public string GetAdress()
        {
            return _address;
        }
    }
}
