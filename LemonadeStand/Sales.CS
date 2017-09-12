using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Sales
    {
        int currentLemonadePrice = //userinput
        int currentRecipeSales = ((currentRecipesSold) * (currentLemonadePrice) + currentRecipeSales);
        int currentRecipesSold = //count
        int todaysSales = currentRecipeSales + todaysSales;
        int weekToDateSales = todaysSales + weekToDateSales;
        int lemonadeMix =  //userinput
        int todaysProfit = todaysSales - suppliesCost;
        int todaysLoss = suppliesCost - todaysSales;
        int weekToDateProfit = todaysProfit + weekToDateProfit;
        

    }
}

newCurrentBalance = ((todaysSales - suppliesCost) + newCurrentBalance);




currentRecipeSales == ((currentLemonadePrice) * (currentRecipesSold));
todaysSales = currentRecipeSales + todaysSales;
currentRecipeSales = 0;


weekToDateSales = todaysSales + weekToDateSales;

if (todaysSales > suppliesCost) {
    todaysProfit = todaysSales - suppliesCost;
    ConsoleWriteLine("You made " + todaysProfit + " coins in profit today. You now have " + newCurrentBalance + "coins.");
}
else if (todaysSales < suppliesCost) {
    todaysLoss = suppliesCost - todaysSales;
    ConsoleWriteLine("You lost " + todaysLoss + "coins today."); 
}    
else {
    Console.WriteLine("You broke even today- no profits and no losses.");
}                                  
                                         
return newCurrentBalance;

