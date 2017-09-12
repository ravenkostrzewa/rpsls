using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Seller1
    {
        public int newCurrentBalance;
        public int coins;
        public int suppliesCost;
        public int lemonCost = 100;
        public int sugarPacketCost = 20;
        public int totalSugarPacketCost;
        public int iceCost = 5;
        public int totalIceCost;
        public int glassCost = 30;
        public int totalGlassCost;
        public int lemons;
        public int sugarPacket;
        public int ice;
        public int glasses;



        ///money is in coins

        public virtual void shoppingList()
        {
            int number = 0;
            Console.WriteLine("How many lemons would you like to buy?");
            try
            {
                number = Int32.Parse(Console.ReadLine());
                int totalLemonCost = (lemonCost) * (number);
            }
            catch
            {
                Console.WriteLine("Only enter integars, no letters or symbols.");
                shoppingList();
            }
            Console.WriteLine("How many packets of sugar would you like to buy?");
            try
            {
                number = Int32.Parse(Console.ReadLine());
                int totalSugarPacketsCost = (sugarPacketCost) * (number);
            }
            catch
            {
                Console.WriteLine("How many ice cubes would you like to buy?");
                shoppingList();
            }
            try
            {
                number = Int32.Parse(Console.ReadLine());
                int totalIceCost = (iceCost) * (number);
            }
            catch
            {
                Console.WriteLine("How many glasses would you like to buy?");
                try
                {
                    number = Int32.Parse(Console.ReadLine());
                    int totalGlassesCost = (glassCost) * (number);
                }
                catch
                {

                    suppliesCost = (lemonCost + sugarPacketCost + iceCost + glassCost);
                }

                return suppliesCost;
                }
            }
}

        public virtual void completeTransaction()
        {
        newCurrentBalance = (newCurrentBalance - suppliesCost);
        }
    }  }


//create lemonade
Console.WriteLine("How many lemons would you like to use?");
//recipe
Console.WriteLine("How many sugar packets would you like to use?");
//recipe
Console.WriteLine("How many ice cubes would you like to use?");
//recipe


//glasses available for sale = ((#lemons + # sugars + #ice cubes)/4);
glasses = (glasses - //glasses available for sale);
