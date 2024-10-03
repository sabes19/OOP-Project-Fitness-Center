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
        public MultiClubMember(int ID, string name, bool isMulticlubMember, int memberPoints) : base(ID, name, isMulticlubMember)
        {
            _memberPoints = memberPoints;
        }
        public override void CheckIn(Club memberClub)
        {
            _memberPoints += 10;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"{Name} has checked into {memberClub.Name}. {Name} has {_memberPoints} points."); // need to add club property, push by josh
            Console.WriteLine("-----------------------------------");
        }
    }
}