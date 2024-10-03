
namespace OOP_Project_Fitness_Center
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FitnessCenter fitnessCenter = new FitnessCenter();
            fitnessCenter.InitializeMembers();
            bool isActiveLoop = true;

            while (isActiveLoop)
            {
                DisplayMenu();
                int userChoice = fitnessCenter.GetUserChoice("Choose and option: ");
                switch (userChoice)
                {
                    case 1:
                        {
                            Console.Clear();
                            fitnessCenter.DisplayMembers();
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            fitnessCenter.DisplayMembers();
                            int memberID = fitnessCenter.GetUserChoice("Enter member ID to check-in: ");

                            Console.Clear();
                            fitnessCenter.DisplayClubs();
                            int club = fitnessCenter.GetUserChoice("\nEnter the club to check-in at (1-4): ") - 1;

                            Console.Clear();
                            fitnessCenter.CheckIn(memberID, club);
                        }
                        break;
                    case 3: //this can be turned into a method return type of tuple
                        {
                            Console.Clear();
                            Console.Write("Enter members name: ");
                            string? name = Console.ReadLine();
                            Console.Clear();

                            Console.WriteLine("Membership type: ");
                            Console.WriteLine("1. Multi-Club Member");
                            Console.WriteLine("2. Single Club Member");

                            int memberType = fitnessCenter.GetUserChoice("Please choose the member type(1 or 2): ");
                            Console.Clear();

                            if(memberType == 1)
                            {
                                fitnessCenter.AddMember(new MultiClubMember(fitnessCenter.GenerateRandomID(), name, true, 0));
                            }
                            if(memberType == 2)
                            {
                                fitnessCenter.DisplayClubs();
                                int clubChoice = fitnessCenter.GetUserChoice("Choose which club you want to be a member of: ") - 1;

                                fitnessCenter.AddMember(new SingleClubMember(fitnessCenter.GenerateRandomID(), name, false, fitnessCenter.Clubs[clubChoice]));

                            }
                        }
                        break;
                    case 4:
                        {
                            fitnessCenter.RemoveMember();
                        }
                        break;
                    case 5:
                        {
                            fitnessCenter.GenerateBill();
                        }
                        break;
                    case 6:
                        {
                            isActiveLoop = false;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("That is not a valid option");
                        }
                        break;
                }
            }
            Console.WriteLine("Please press enter to exit application...");
            Console.ReadLine();
        }
        public static void DisplayMenu()
        {
            Console.WriteLine("----- Fitness Center Management System -----");
            Console.WriteLine("1. Display Members");
            Console.WriteLine("2. Check In Member");
            Console.WriteLine("3. Add Member");
            Console.WriteLine("4. Remove Member");
            Console.WriteLine("5. Generate Bill");
            Console.WriteLine("6. Exit");
        }
    }
}
