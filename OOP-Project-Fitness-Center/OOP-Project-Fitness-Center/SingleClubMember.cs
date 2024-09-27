using System;


namespace OOP_Project_Fitness_Center
{
    public class SingleClubMember : Member
    {
        public Club memberClub { get; set; }   // assign member a club
     
        public SingleClubMember(int ID, string Name) : base(ID, Name) { }

        public override void CheckIn(Club club)
        {
            if (this.memberClub != club)
            {
                throw new InvalidOperationException($"Member can not check in. Member is not assigned to this club.");
            }
            else
            {
                Console.WriteLine($"Member has successfully checked in.");
            }
        }
    }
}
