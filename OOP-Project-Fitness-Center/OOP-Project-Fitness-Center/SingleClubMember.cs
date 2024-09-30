using System;


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
            {
                Console.WriteLine("------------------------------------");
                throw new InvalidOperationException($"Member can not check in. Member is not assigned to this club.");
                Console.WriteLine("------------------------------------");
            }
            else
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"Member has successfully checked in.");
                Console.WriteLine("------------------------------------");
            }
        }

        // Display Member info method
        public override void DisplayMemberInfo()
        {
            Console.WriteLine($"Club ID: {ID}, Name: {Name}, Club: {club}");
        }





    }
}
