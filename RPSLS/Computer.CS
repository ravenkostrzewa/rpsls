using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        

        public override void MakeChoice()
        {
            int computerChoice = GetRandomChoice();
            if (computerChoice == 1)
            {
                choice = "rock";
            }
            else if (computerChoice ==2)
            {
                choice = "paper";
            }
            else if (computerChoice == 3)
            {
                choice = "scissors";            }
            else if (computerChoice == 4)
            {
                choice = "lizard";
            }
            else if (computerChoice == 5)
            {
                choice = "spock";
            }
        }
        public int GetRandomChoice()
        {
            Random random = new Random();
            int computerChoice = random.Next(1, 5);
            return computerChoice;
        }

    }
}
