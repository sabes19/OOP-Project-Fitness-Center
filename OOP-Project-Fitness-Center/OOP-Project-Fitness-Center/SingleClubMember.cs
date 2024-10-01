using System;
using System.Xml.Linq;


namespace OOP_Project_Fitness_Center
{
    public class SingleClubMember : Members
    {
        public Club memberClub { get; set; }   // assign member a club

        public SingleClubMember(int ID, string Name) : base(ID, Name) { }

        // checkin Method
        public override void CheckIn(Club club)
        {
            if (this.memberClub != club)
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Member has successfully checked in.");
            Console.WriteLine("------------------------------------");
        }

        public override void DisplayMemberInfo()
        {
            Console.WriteLine($"Club ID: {ID}, Name: {Name}, Club: {_name}"); // do i have the wrong variable for _name?
        }

        public override void GenerateBill()
        {
            throw new NotImplementedException();
        }
    }
}
