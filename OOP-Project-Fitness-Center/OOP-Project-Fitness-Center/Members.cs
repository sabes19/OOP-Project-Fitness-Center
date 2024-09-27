using System;


namespace OOP_Project_Fitness_Center
{
    // Member class
    public abstract class Members
    {
        // properties of the Members class that will be inherited by SingleClubMember and MultiClubMember
        public int ID               { get; set; }   // member ID
        public string Name          { get; set; }   // Member name
        //public string JoinDateTime  { get; set; }   // stores date time as an integer to be used for membership fee calculation later
        public bool IsCheckedIn { get; set; } = false;   // Is the member checked in at a location, already initialized to not checked in

        // constructors
        public Members(int id, string name)
        {
            ID = id;
            Name = name;
        }



        // method - CheckIn
        public abstract void CheckIn(Club memberClub);
    }
}
