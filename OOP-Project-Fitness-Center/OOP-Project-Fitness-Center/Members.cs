﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Fitness_Center
{
    // Member class
    public abstract class Members
    {
        // properties of the Members class that will be inherited by SingleClubMember and MultiClubMember
        public int ID               { get; set; }
        public string Name          { get; set; }
        public string Club          { get; set; }
        public string JoinDateTime  { get; set; }  // stores date time as an integer to be used for membership fee calculation later
        public bool IsCheckedIn { get; set; }      // Is the member checked in at a location

        // constructors
        public Members(int id, string name, string club, string joinDateTime)
        {
            ID = id;
            Name = name;
            Club = club;
            JoinDateTime = joinDateTime;
        }

        // method - CheckIn
        public abstract void CheckIn(string club);
    }
}
