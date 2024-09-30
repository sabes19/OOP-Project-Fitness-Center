using System;


namespace OOP_Project_Fitness_Center
{
    public class MultiClubMember : Members
    {
        public int MemberPoints { get; set; }
        public MultiClubMember(int ID, string name) : base(ID, name) 
        { 
            MemberPoints = 0;
        }

        // Checkin Method for Multiclub members
        // adds to MemberPoints

        public override void CheckIn(Club memberClub)
        {
            MemberPoints += 10; // member points increase by 10
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"{Name} has checked into {___}. {Name} has {MemberPoints} points."); // need to add club property, push by josh
            Console.WriteLine("-----------------------------------");
            throw new NotImplementedException();
        }
    }
}
