using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Fitness_Center
{
    public class Club
    {
        private static List<Member> _clubMembers = new List<Member>();
        public Dictionary<string, string> Clubs { get; private set; }
        public Club()
        {
            Clubs = new Dictionary<string, string>
            {
                { "Fitness Center 1", "Denver,CO" },
                { "Fitness Center 2", "Pittsburgh,PA" },
                { "Fitness Center 3", "Detroit,MI" },
                { "Fitness Center 4", "Chicago,IL" }
            };
        }

        public static (int,string) GetMemberInfo()
        {
            Random rnd = new Random();
            (int, string) memberInfo;

            do
            {
                Console.Write("Please enter the new members name: ");
                memberInfo.Item2 = Console.ReadLine();
            } while (String.IsNullOrEmpty(memberInfo.Item2));

            memberInfo.Item1 = rnd.Next(10000,100000);

            return memberInfo;
        }
        public static void AddMember(Member member)
        {
            _clubMembers.Add(member);
        }
        public static void RemoveMember(Member member)
        {
            _clubMembers.Remove(member);
        }
    }
}
