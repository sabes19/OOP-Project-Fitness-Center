using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Fitness_Center
{
    public class SingleClubMember : Members
    {
        public Club Club { get; set; }   // assign member a club
     
        public SingleClubMember(int ID, string Name) : base(ID, Name) { }

        public override void CheckIn(Club club)
        {
            throw new NotImplementedException();
        }
    }
}
