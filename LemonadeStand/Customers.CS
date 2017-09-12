using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customers
    {
        public int cupsBought;
        public int goodDeal;
        public int recipeEnjoyment;
        public int lemonadeWeather;
        public int coins;
        Random rnd = new Random();

        public virtual void BuyLemonade()
        {
            goodDeal = (((rnd.Next(0, 10)) % 0);
            recipeEnjoyment = rnd.Next(0, 10);
            lemonadeWeather = rnd.Next(0, 10);
            cupsBought = ((lemonadeWeather + recipeEnjoyment) / 4) * (goodDeal);
        }

        public virtual void LemonadeSold()
        {
            return glassesSold;
        }
    }
}
