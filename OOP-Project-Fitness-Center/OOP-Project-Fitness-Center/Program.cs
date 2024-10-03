
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
                fitnessCenter.DisplayMenu();
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
                            int club = -1;
                            do
                            {
                                fitnessCenter.DisplayClubs();
                                club = fitnessCenter.GetUserChoice("\nEnter the club to check-in at (1-4): ") - 1;
                            } while (club != 0 || club != 1 || club != 2 || club != 3);

                            Console.Clear();
                            fitnessCenter.CheckIn(memberID, club);
                        }
                        break;
                    case 3:
                        {
                            (string, bool) memberInfo = fitnessCenter.GetUserInfo();

                            if(memberInfo.Item2 == true)
                            {
                                fitnessCenter.AddMember(new MultiClubMember(fitnessCenter.GenerateRandomID(), memberInfo.Item1, true, 0));
                            }
                            else
                            {
                                int clubChoice = -1;
                                do
                                {
                                    fitnessCenter.DisplayClubs();
                                    clubChoice = fitnessCenter.GetUserChoice("Choose which club you want to be a member of: ") - 1;
                                    Console.Clear();
                                } while (clubChoice < 0 || clubChoice >= 3);
                                fitnessCenter.AddMember(new SingleClubMember(fitnessCenter.GenerateRandomID(), memberInfo.Item1, false, fitnessCenter.Clubs[clubChoice]));
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
    }
}
