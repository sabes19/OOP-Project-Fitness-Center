using System;

namespace OOP_Project_Fitness_Center
{
    public class FitnessCenter
    {
        public Random rnd = new Random();
        private List<Member> members = new List<Member>();
        public List<Club> Clubs = new List<Club>();

        public FitnessCenter()
        {
            Clubs.Add(new Club("Fitness Center 1", "Chicago,IL"));
            Clubs.Add(new Club("Fitness Center 2", "Detroit,MI"));
            Clubs.Add(new Club("Fitness Center 3", "Pittsburgh,PA"));
            Clubs.Add(new Club("Fitness Center 4", "Charlotte,NC"));
        }
        public int GenerateRandomID()
        {
            return rnd.Next(10000,100000);
        }
        public void InitializeMembers()
        {
            members.Add(new SingleClubMember(GenerateRandomID(), "Josh", false, Clubs[0]));
            members.Add(new SingleClubMember(GenerateRandomID(), "Ryan", false, Clubs[2]));
            members.Add(new SingleClubMember(GenerateRandomID(), "Kelly", false, Clubs[3]));
            members.Add(new SingleClubMember(GenerateRandomID(), "James", false, Clubs[1]));

            members.Add(new MultiClubMember(GenerateRandomID(), "Jamie", false, 30));
            members.Add(new MultiClubMember(GenerateRandomID(), "Tyler", false, 100));
            members.Add(new MultiClubMember(GenerateRandomID(), "Jackie", false, 60));
            members.Add(new MultiClubMember(GenerateRandomID(), "Gerald", false, 0));
        }
        public void CheckIn(int id, int clubIndex)
        {
            var member = members.Find(m => m.ID == id);
            Club clubCheckIn = Clubs.ElementAt(clubIndex);

            member.CheckIn(clubCheckIn);
        }
        public void DisplayMembers()
        {
            Console.WriteLine("\n----------Members---------");
            for (int i = 0; i < members.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{members[i].Name.PadRight(10)}ID: {members[i].ID}");
            }
            Console.WriteLine();
        }
        public void GenerateBill()
        {
            DisplayMembers();
            int memberID = GetUserChoice("Please enter member ID to generate bill for: ");
            foreach (Member member in members)
            {
                if(member.ID == memberID)
                {
                    Console.Clear();
                    Console.WriteLine($"A bill has been sent to {member.Name}.");
                    if(member is MultiClubMember multi)
                    {
                        Console.WriteLine($"{member.Name} has {multi.MemberPoints} membership points\n");
                    }
                    else
                    {
                        Console.WriteLine($"{member.Name} is a single club member.\n");
                    }
                }
                if (member == null)
                {
                    Console.WriteLine($"Member ID ({memberID}) was not found, please enter a valid member ID.");
                }
            }
        }
        public void RemoveMember()
        {
            Console.Clear();

            DisplayMembers();
            int choice = GetUserChoice("Which member do you want to remove: ") - 1;

            Console.Clear();

            Console.WriteLine($"{members[choice].Name} has been removed.");
            members.RemoveAt(choice);
        }
        public void AddMember(Member member)
        {
            Console.Clear();
            members.Add(member);
            Console.WriteLine($"Added member: {member.Name}.\n");
        }
        public int GetUserChoice(string message)
        {
            bool isParsable;
            int userInput;
            do
            {
                Console.Write(message);
                isParsable = int.TryParse(Console.ReadLine(), out userInput);
            } while (!isParsable);

            return userInput;
        }
        public void DisplayClubs()
        {
            for (int i = 0; i < Clubs.Count; i++)
            {
                Console.WriteLine($"{i + 1}: Club: {Clubs[i].Name} Address: {Clubs[i].Address}");
            }
        }
    }
}
