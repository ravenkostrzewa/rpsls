using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        public string GetName()
        {
            return name;
        }
        public override void SetName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();           
        }
    }
}
