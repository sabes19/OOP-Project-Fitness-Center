using System;

namespace OOP_Project_Fitness_Center
{
    public class SingleClubMember : Member
    {
        private Club _memberClub;
        public Club MemberClub
        { 
            get {  return _memberClub; }
            set { _memberClub = value; }
        }
        public SingleClubMember(int ID, string Name, bool isMulticlubMember) : base(ID, Name, isMulticlubMember)
        {
            _memberClub = MemberClub;
        }
        public override void CheckIn(Club club)
        {
            if (_memberClub != club)
                Console.WriteLine("------------------------------------");
            Console.WriteLine($"Member has successfully checked in.");
            Console.WriteLine("------------------------------------");
        }

        public override void GenerateBill()
        {
            throw new NotImplementedException();
        }
    }
}
