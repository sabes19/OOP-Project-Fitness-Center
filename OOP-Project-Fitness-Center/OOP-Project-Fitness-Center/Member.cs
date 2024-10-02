﻿using System;

namespace OOP_Project_Fitness_Center
{
    public abstract class Member
    {
        // properties of the Members class that will be inherited by SingleClubMember and MultiClubMember
        private int _id;
        private string _name;
        private bool _isMulticlubMember;

        public int ID               
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public bool IsMulticlubMember
        {
            get { return _isMulticlubMember; }
            set { _isMulticlubMember = value; }
        }
                public bool IsCheckedIn { get; set; } = false;   // Is the member checked in at a location, already initialized to not checked in

        // constructor
        public Member(int id, string name, bool isMulticlubMember)
        {
            _id = id;
            _name = name;
            _isMulticlubMember = isMulticlubMember; 
        }

        protected Member(int iD, string name)
        {
            ID=iD;
            Name=name;
        }


        // method - CheckIn
        public abstract void CheckIn(Club memberClub);
    }
}
