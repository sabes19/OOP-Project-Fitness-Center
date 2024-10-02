
namespace OOP_Project_Fitness_Center
{
    internal class Program
    {
        static List<Member> memberList = new List<Member>();
        static List<Club> clubList = new List<Club>();
        static void Main(string[] args)
        {
            InitializeClubs();
            GetExecuteMenuAction();
            
        }
        static void GetExecuteMenuAction()
        {
            bool isActiveLoop = true;

            while (isActiveLoop)
            {
                DisplayMenu();
                int userChoice = GetUserChoice();
                switch (userChoice)
                {
                    case 1:
                        {
                            DisplayMembers(memberList);
                        }
                        break;
                    case 2: //Check in
                        {

                        }
                        break;
                    case 3:
                        {
                            (int, string) newInfo = Club.GetMemberInfo();
                            memberList.Add(new SingleClubMember(newInfo.Item1, newInfo.Item2));
                            //this needs to check if they are multi club or single club
                            //possibly add third data type of bool to make them multi or single club member
                        }
                        break;
                    case 4:
                        {
                            RemoveMember(); // need to make sure the user enters a number between 1-6
                        }
                        break;
                    case 5: //Generate Bill
                        {

                        }
                        break;
                    case 6:
                        {
                            isActiveLoop = false;
                        }
                        break;
                }
            }
        }
        static void RemoveMember()
        {
            DisplayMembers(memberList);
            int choice = GetUserChoice() - 1;

            memberList.RemoveAt(choice);
        }
        static void DisplayMembers(List<Member> members)
        {
            for (int i = 0; i < members.Count; i++)
            {
                Console.WriteLine($"{i + 1}Name: {members[i].Name} ID: {members[i].ID}");
            }
        }
        static int GetUserChoice()
        {
            bool isParsable;
            int userInput;
            do
            {
                Console.Write("Choose an option: ");
                isParsable = int.TryParse(Console.ReadLine(), out userInput);
            }while (!isParsable);

            return userInput;
        }
        static void DisplayMenu()
        {
            Console.WriteLine("----- Fitness Center Management System -----");
            Console.WriteLine("1. Display Members");
            Console.WriteLine("2. Check In Member");
            Console.WriteLine("3. Add Member");
            Console.WriteLine("4. Remove Member");
            Console.WriteLine("5. Generate Bill");
            Console.WriteLine("6. Exit");
        }
        static void InitializeClubs()
        {
            clubList.Add(new Club("Fitness Center 1", "Chicago,IL"));
            clubList.Add(new Club("Fitness Center 2", "Detroit,MI"));
            clubList.Add(new Club("Fitness Center 3", "Pittsburgh,PA"));
            clubList.Add(new Club("Fitness Center 1", "Charlotte,NC"));
        }
        static void InitializeMembers()
        {
            
        }

    }
}
