using System;
using System.Linq.Expressions;

namespace OOP_Project_Fitness_Center
{
    public class SingleClubMember : Member
    {
        private Club _memberClub;
        public Club MemberClub
        {
            get { return _memberClub; }
            set { _memberClub = value; }
        }
        public SingleClubMember(string Name, bool isMulticlubMember, Club memberClub) : base(Name, isMulticlubMember)
        {
            _memberClub = memberClub;
        }
        public override void CheckIn(Club club)
        {
            try
            {
                // Check if member's club matches
                if (_memberClub != club)
                {
                    Console.WriteLine($"{Name} cannot check in. {Name} is assigned to another club.");
                }
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine($"Member has successfully checked in.");
                    Console.WriteLine("------------------------------------");
                }
            }
            catch (InvalidOperationException ex)
            {
                // handle the case when a member checks into the wrong location
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
