using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackSch
{
    internal class Program
    {
        class BlackjackGame
        {
            private Deck deck;
            private Player player;
            private Player dealer;
            private int playerBalance;

            public BlackjackGame()
            {
                playerBalance = 1000; // Set initial player balance to 1000 dollars
                ResetGame();
            }

            public void PlayGame()
            {
                while (playerBalance >= 1)
                {
                    Console.WriteLine($"\nPlayer's balance: ${playerBalance}");

                    Console.WriteLine("\nPlace your bet (minimum $1, enter 0 to quit):");
                    int betAmount;

                    while (true)
                    {
                        if (!int.TryParse(Console.ReadLine(), out betAmount))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid amount.");
                            continue;
                        }

                        if (betAmount == 0)
                        {
                            Console.WriteLine("Thank you for playing!");
                            return;
                        }

                        if (betAmount < 1 || betAmount > playerBalance)
                        {
                            Console.WriteLine("Invalid bet amount. Please bet between $1 and your current balance.");
                        }
                        else
                        {
                            break;
                        }
                    }

                    // Display initial hands and scores
                    Console.WriteLine("Player's Hand:");
                    foreach (var card in player.Hand)
                    {
                        Console.WriteLine($"{card.Face} of {card.Suit}");
                    }
                    Console.WriteLine($"Player's Score: {player.Score}");

                    Console.WriteLine("\nDealer's Hand:");
                    foreach (var card in dealer.Hand)
                    {
                        Console.WriteLine($"{card.Face} of {card.Suit}");
                    }
                    Console.WriteLine($"Dealer's Score: {dealer.Score}");

                    // Player's turn and dealer's turn
                    while (true)
                    {
                        Console.WriteLine("\nPlayer's turn: (H)it or (S)tand?");
                        string choice = Console.ReadLine().ToUpper();

                        if (choice == "H")
                        {
                            player.Hand.Add(deck.DealCard());
                            player.CalculateScore();

                            Console.WriteLine($"Player's Score: {player.Score}");

                            if (player.Score > 21)
                            {
                                Console.WriteLine("Player busts. Dealer wins!");
                                return;
                            }
                        }
                        else if (choice == "S")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter 'H' for Hit or 'S' for Stand.");
                        }
                    }
                    // Check player's and dealer's scores and determine the winner
                    while (dealer.Score < 17)
            {
                dealer.Hand.Add(deck.DealCard());
                dealer.CalculateScore();
            }

            // Display final hands and scores
            Console.WriteLine("\nPlayer's Hand:");
            foreach (var card in player.Hand)
            {
                Console.WriteLine($"{card.Face} of {card.Suit}");
            }
            Console.WriteLine($"Player's Score: {player.Score}");

            Console.WriteLine("\nDealer's Hand:");
            foreach (var card in dealer.Hand)
            {
                Console.WriteLine($"{card.Face} of {card.Suit}");
            }
            Console.WriteLine($"Dealer's Score: {dealer.Score}");
                    // Adjust player balance based on the game result
                    if (player.Score > 21) // Player busts
                    {
                        playerBalance -= betAmount;
                        Console.WriteLine($"Player busts. Dealer wins ${betAmount}. New balance: ${playerBalance}");
                    }
                    else if (dealer.Score > 21) // Dealer busts
                    {
                        playerBalance += betAmount;
                        Console.WriteLine($"Dealer busts. Player wins ${betAmount}! New balance: ${playerBalance}");
                    }
                    else if (player.Score > dealer.Score) // Player's score higher than dealer's score
                    {
                        playerBalance += betAmount;
                        Console.WriteLine($"Player wins ${betAmount}! New balance: ${playerBalance}");
                    }
                    else if (player.Score < dealer.Score) // Dealer's score higher than player's score
                    {
                        playerBalance -= betAmount;
                        Console.WriteLine($"Dealer wins ${betAmount}. New balance: ${playerBalance}");
                    }
                    else // It's a tie
                    {
                        Console.WriteLine("It's a tie!");
                        Console.WriteLine($"Balance remains: ${playerBalance}");
                    }

                    ResetGame();
                }

                Console.WriteLine("You're out of money. Thank you for playing!");
            }

            private void ResetGame()
            {
                // Reset player, dealer, and deck for a new game
                deck = new Deck();
                deck.Shuffle();

                player = new Player();
                dealer = new Player();

                player.Hand.Add(deck.DealCard());
                dealer.Hand.Add(deck.DealCard());
                player.Hand.Add(deck.DealCard());
                dealer.Hand.Add(deck.DealCard());

                player.CalculateScore();
                dealer.CalculateScore();
            }


            class Program
            {
                static void Main(string[] args)
                {
                    BlackjackGame game = new BlackjackGame();
                    game.PlayGame();
                }
            }
        }
    }
}


    

