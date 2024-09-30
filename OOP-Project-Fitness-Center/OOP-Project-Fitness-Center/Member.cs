using System;


namespace OOP_Project_Fitness_Center
{
    // Member class
    public abstract class Member
    {
        // properties of the Members class that will be inherited by SingleClubMember and MultiClubMember
        public int ID               { get; set; }   // member ID
        public string Name          { get; set; }   // Member name
        
        //public string JoinDateTime  { get; set; }   // stores date time as an integer to be used for membership fee calculation later
        
        public bool IsCheckedIn { get; set; } = false;   // Is the member checked in at a location, already initialized to not checked in

        // constructors
        public Member(int id, string name)
        {
            ID = id;
            Name = name;
        }


        // method to display member info
        public abstract void DisplayMemberInfo();


        // method to generate bill
        public abstract void GenerateBill();


        // method - CheckIn
        public abstract void CheckIn(Club memberClub);
    }
}
