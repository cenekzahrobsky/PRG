using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deathroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Deathroll!");

            Console.Write("Enter your nickname: ");
            string playerName = Console.ReadLine();

            Console.Write("Enter initial bet: ");
            int maxRollValue = int.Parse(Console.ReadLine());

            int currentMaxRollValue = maxRollValue; 

            Random random = new Random();

            int playerRoll;
            int computerRoll;
            bool playerTurn = true;

            Console.WriteLine($"Roll the dice (1 to {currentMaxRollValue}) to start the game...");

            while (true)
            {
                Console.ReadLine();

                if (playerTurn)
                {
                    playerRoll = random.Next(1, currentMaxRollValue + 1);

                    Console.WriteLine($"{playerName} rolls: {playerRoll}");

                    if (playerRoll == 1)
                    {
                        Console.WriteLine($"{playerName} rolled 1, You lose!");
                        break;
                    }

                    currentMaxRollValue = playerRoll;
                }
                else
                {
                    computerRoll = random.Next(1, currentMaxRollValue + 1);

                    Console.WriteLine("Computer rolls: " + computerRoll);

                    if (computerRoll == 1)
                    {
                        Console.WriteLine("Computer rolled 1, You win!");
                        break;
                    }

                    currentMaxRollValue = computerRoll;
                }

                playerTurn = !playerTurn;
            }

            Console.WriteLine("Game over!");
            Console.ReadKey();
        }
    }
}
