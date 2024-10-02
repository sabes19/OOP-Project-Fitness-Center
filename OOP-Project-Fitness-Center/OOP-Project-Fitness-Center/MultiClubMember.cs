using System;

namespace OOP_Project_Fitness_Center
{
    public class MultiClubMember : Member
    {
        private int _memberPoints;
        public int MemberPoints 
        { 
            get {  return _memberPoints; }
            set { _memberPoints = value; }
        }
        public MultiClubMember(int ID, string name, bool isMulticlubMember) : base(ID, name, isMulticlubMember)
        {
            _memberPoints = 0;
        }
        public override void CheckIn(Club memberClub)
        {
            MemberPoints += 10; // member points increase by 10
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"{Name} has checked into {memberClub}. {Name} has {MemberPoints} points."); // need to add club property, push by josh
            Console.WriteLine("-----------------------------------");
            throw new NotImplementedException();
        }
        public override void GenerateBill(int id)
        {
            throw new NotImplementedException();
        }
    }
}
