using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        public string name;
        public string choice;
        public int score = 0;


        public virtual void MakeChoice()
        {
            Console.WriteLine(name + ", choose rock, paper, scissors, lizard, or spock.");
            choice = Console.ReadLine();
        }
        public void AddToScore()
        {
            score += 1;
        }
        public int GetScore()
        {
            return score;
        }
        public virtual void SetName()
        {

        }
    }
}




