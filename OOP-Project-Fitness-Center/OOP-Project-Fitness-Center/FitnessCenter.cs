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
        public void InitializeMembers()
        {
            members.Add(new SingleClubMember("Josh", false, Clubs[0]));
            members.Add(new SingleClubMember("Ryan", false, Clubs[2]));
            members.Add(new SingleClubMember("Kelly", false, Clubs[3]));
            members.Add(new SingleClubMember("James", false, Clubs[1]));

            members.Add(new MultiClubMember("Jamie", false, 30));
            members.Add(new MultiClubMember("Tyler", false, 100));
            members.Add(new MultiClubMember("Jackie", false, 60));
            members.Add(new MultiClubMember("Gerald", false, 0));
        }
        public void DisplayMenu()
        {
            Console.WriteLine("----- Fitness Center Management System -----");
            Console.WriteLine("1. Display Members");
            Console.WriteLine("2. Check-in Member");
            Console.WriteLine("3. Add Member");
            Console.WriteLine("4. Remove Member");
            Console.WriteLine("5. Generate Bill");
            Console.WriteLine("6. Exit");
        }
        public void CheckIn(int id, int clubIndex)
        {
            var member = members.Find(m => m.ID == id);           
            Club clubCheckIn = Clubs.ElementAt(clubIndex);

            if (member == null)
            {
                Console.WriteLine("\n------------------------------------------------------------------------");
                Console.WriteLine($"Member ID ({id}) was not found, please enter a valid member ID.");
                Console.WriteLine("------------------------------------------------------------------------\n");
            }
            else
            {
                member.CheckIn(clubCheckIn);
            }
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
                else
                {
                    Console.WriteLine("\n------------------------------------------------------------------------");
                    Console.WriteLine($"Member ID ({memberID}) was not found, please enter a valid member ID.");
                    Console.WriteLine("------------------------------------------------------------------------\n");
                    break;
                }
            }
        }
        public (string, bool) GetUserInfo()
        {
            Console.Clear();
            string? name = string.Empty;

            do
            {
                Console.Write("Enter members name: ");
                name = Console.ReadLine();
                Console.Clear();
            } while (string.IsNullOrEmpty(name));
            
            int memberType;
            do
            {
                Console.WriteLine("Membership type: ");
                Console.WriteLine("1. Multi-Club Member");
                Console.WriteLine("2. Single Club Member");

                memberType = GetUserChoice("Please choose the member type (1 or 2): ");
                Console.Clear();
            } while (memberType != 1 && memberType != 2);

            if (memberType == 1)
            {
                return (name, true);
            }
            else
            {
               return (name, false);
            }
        }
        public void RemoveMember()
        {
            Console.Clear();
            int choice;
            do
            {
                DisplayMembers();
                choice = GetUserChoice("Which member do you want to remove: ") - 1;
                Console.Clear();
            } while (choice < 0 || choice >= members.Count);

            Console.WriteLine($"\n{members[choice].Name} has been removed.\n");
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
                Console.Clear();
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
