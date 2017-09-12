using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        Player playerOne;
        Player playerTwo;

        public void SetupGame()
        {
            SetUpPlayers();
        }
        public void SetUpPlayers()
        {
            Console.WriteLine("Rules for Rock, Paper, Scissors, Lizard, Spock: Pick a gesture to beat your opponent. We will play best of three rounds. Scissors cuts paper. Paper covers rock. Rock crushes lizard. Lizard poisons spock. Spock smashes scissors. Scissors decapitates lizard. Lizard eats paper. Paper disproves spock. Spock vaporizes rock. Rock crushes scissors.");
            Console.WriteLine("Would you like to play with a friend? Enter yes to play with a friend or no to play against the computer.");
            string userInput = Console.ReadLine();
            if (userInput == "yes")
            {
                playerOne = new Human();
                playerTwo = new Human();
                playerOne.SetName();
                playerTwo.SetName();
                Console.WriteLine(playerOne.name + " VS. " + playerTwo.name + "! Let the game begin!");
            }
            else if (userInput == "no")
            {
                playerOne = new Human();
                playerTwo = new Computer();
                playerOne.SetName();
                playerTwo.name = "Qwerty";
                Console.WriteLine(playerOne.name + " Vs. Qwerty! Let the game begin!");
            }
        }

        public void RunGame()
        {
            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.MakeChoice();
                playerTwo.MakeChoice();

                if (playerOne.choice != "rock" && playerOne.choice != "paper" && playerOne.choice != "scissors" && playerOne.choice != "lizard" && playerOne.choice != "spock")
                {
                    Console.WriteLine("There was an invalid entry. Let's try that round again. Choose rock, paper, scissors, lizard, or spock.");
                }
                else if (playerOne.choice != "rock" && playerOne.choice != "paper" && playerOne.choice != "scissors" && playerOne.choice != "lizard" && playerOne.choice != "spock")
                {
                    Console.WriteLine("There was an invalid entry. Let's try that round again. Choose rock, paper, scissors, lizard, or spock.");
                }
               else DetermineWinner(); {
                }
            }
            if (playerOne.score == 2)
            {
                Console.WriteLine(playerOne.name + " wins!");
            }
            else if (playerTwo.score == 2)
            {
                Console.WriteLine(playerTwo.name + " wins!");
            }
            Console.WriteLine("Game Over");
        }
        private void DetermineWinner()
        {
            if (playerOne.choice == "rock" && playerTwo.choice == "scissors")
            {
                playerOne.AddToScore();
                Console.WriteLine(playerOne.name + " gets a point.");
            }
            else if (playerOne.choice == "paper" && playerTwo.choice == "scissors")
            {
                playerTwo.AddToScore();
                Console.WriteLine(playerTwo.name + " gets a point.");
            }
            else if (playerOne.choice == "paper" && playerTwo.choice == "rock")
            {
                playerOne.AddToScore();
                Console.WriteLine(playerOne.name + " gets a point.");
            }
            else if (playerOne.choice == "scissors" && playerTwo.choice == "rock")
            {
                playerTwo.AddToScore();
                Console.WriteLine(playerTwo.name + " gets a point.");
            }
            else if (playerOne.choice == "rock" && playerTwo.choice == "paper")
            {
                playerTwo.AddToScore();
                Console.WriteLine(playerTwo.name + " gets a point.");
            }
            else if (playerOne.choice == "scissors" && playerTwo.choice == "paper")
            {
                playerOne.AddToScore();
                Console.WriteLine(playerOne.name + " gets a point.");
            }
            else if (playerOne.choice == "rock" && playerTwo.choice == "rock")
            {
                Console.WriteLine("It's a tie!");
            }
            else if (playerOne.choice == "paper" && playerTwo.choice == "paper")
            {
                Console.WriteLine("It's a tie!");
            }
            else if (playerOne.choice == "scissors" && playerTwo.choice == "scissors")
            {
                Console.WriteLine("It's a tie!");
            }
            else if (playerOne.choice == "spock" && playerTwo.choice == "spock")
            {
                Console.WriteLine("It's a tie!");
            }
            else if (playerOne.choice == "lizard" && playerTwo.choice == "lizard")
            {
                Console.WriteLine("It's a tie!");
            }
            else if (playerOne.choice == "lizard" && playerTwo.choice == "rock")
            {
                playerTwo.AddToScore();
                Console.WriteLine(playerTwo.name + " gets a point.");
            }
            else if (playerOne.choice == "lizard" && playerTwo.choice == "spock")
            {
                playerOne.AddToScore();
                Console.WriteLine(playerOne.name + " gets a point.");
            }
            else if (playerOne.choice == "scissors" && playerTwo.choice == "lizard")
            {
                playerOne.AddToScore();
                Console.WriteLine(playerOne.name + " gets a point.");
            }
            else if (playerOne.choice == "spock" && playerTwo.choice == "scissors")
            {
                playerOne.AddToScore();
                Console.WriteLine(playerOne.name + " gets a point.");
            }
            else if (playerOne.choice == "rock" && playerTwo.choice == "lizard")
            {
                playerOne.AddToScore();
                Console.WriteLine(playerOne.name + " gets a point.");
            }
            else if (playerOne.choice == "spock" && playerTwo.choice == "lizard")
            {
                playerTwo.AddToScore();
                Console.WriteLine(playerTwo.name + " gets a point.");
            }
            else if (playerOne.choice == "lizard" && playerTwo.choice == "scissors")
            {
                playerTwo.AddToScore();
                Console.WriteLine(playerTwo.name + " gets a point.");
            }
            else if (playerOne.choice == "scissors" && playerTwo.choice == "spock")
            {
                playerTwo.AddToScore();
                Console.WriteLine(playerTwo.name + " gets a point.");
            }
            else if (playerOne.choice == "lizard" && playerTwo.choice == "paper")
            {
                playerOne.AddToScore();
                Console.WriteLine(playerOne.name + " gets a point.");
            }
            else if (playerOne.choice == "paper" && playerTwo.choice == "lizard")
            {
                playerTwo.AddToScore();
                Console.WriteLine(playerTwo.name + " gets a point.");
            }
            else if (playerOne.choice == "paper" && playerTwo.choice == "spock")
            {
                playerOne.AddToScore();
                Console.WriteLine(playerOne.name + " gets a point.");
            }
            else if (playerOne.choice == "spock" && playerTwo.choice == "paper")
            {
                playerTwo.AddToScore();
                Console.WriteLine(playerTwo.name + " gets a point.");
            }
            else if (playerOne.choice == "spock" && playerTwo.choice == "rock")
            {
                playerOne.AddToScore();
                Console.WriteLine(playerOne.name + " gets a point.");
            }
            else if (playerOne.choice == "rock" && playerTwo.choice == "spock")
            {
                playerTwo.AddToScore();
                Console.WriteLine(playerTwo.name + " gets a point.");
            }

            
        }

    }
}