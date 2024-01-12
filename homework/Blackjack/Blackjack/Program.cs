using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlackjackSch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Random rnd = new Random();
            List<Card> deck = new List<Card>();
            List<Card> playerHand = new List<Card>();
            List<Card> dealerHand = new List<Card>();
            Console.WriteLine("\n");
            Console.WriteLine($"Welcome, {player.Nickname}!");
            double playerBalance = 1000;

            // Function to reset the game
            void ResetGame()
            {
                List<Card> newDeck = new Deck().cards;
                deck = newDeck.ToList();
                deck = deck.OrderBy(c => rnd.Next()).ToList(); //tady poradilo gpt, nevedel jsem, jak ty karty zamichat jinak nez nejakym slozitym cyklem

                playerHand.Clear();
                dealerHand.Clear();


                playerHand.Add(deck[0]);
                deck.RemoveAt(0);
                dealerHand.Add(deck[0]);
                deck.RemoveAt(0);
                playerHand.Add(deck[0]);
                deck.RemoveAt(0);
                dealerHand.Add(deck[0]);
                deck.RemoveAt(0);
            }

            // Function to calculate score
            int CalculateScore(List<Card> hand)
            {
                int score = hand.Sum(card => card.Value);
                if (score > 21)
                {
                    foreach (var card in hand)
                    {
                        if (card.Face == "A")
                        {
                            score -= 10;
                            if (score <= 21)
                                break;
                        }
                    }
                }
                return score;
            }

            // Function to display hands
            void DisplayHands(bool showAll = false)
            {
                Console.WriteLine("\n");
                Console.WriteLine($"{player.Nickname}'s Hand:");
                foreach (var card in playerHand)
                {
                    Console.WriteLine($"{card.Face} of {card.Suit}");
                }
                Console.WriteLine($"{player.Nickname}'s Score: {CalculateScore(playerHand)}");
                Console.WriteLine("\n");
                Console.WriteLine("Dealer's Hand:");
                int count = 0;
                foreach (var card in dealerHand)
                {
                    if (showAll || count > 0)
                        Console.WriteLine($"{card.Face} of {card.Suit}");
                    else
                        Console.WriteLine("Hidden Card");

                    count++;
                }
                if (showAll)
                {
                    Console.WriteLine($"Dealer's Score: {CalculateScore(dealerHand)}");
                }
            }

            // Main game loop
            while (playerBalance >= 1)
            {
                Console.WriteLine("\n");
                Console.WriteLine($"Balance: ${playerBalance}");
                Console.WriteLine("\n");
                Console.WriteLine("Place your bet (minimum $1, enter 0 to quit):");
                double betAmount;

                while (true)
                {
                    if (!double.TryParse(Console.ReadLine(), out betAmount))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid amount.");
                        continue;
                    }

                    if (betAmount == 0)
                    {
                        Console.WriteLine("Thank you for playing!");
                        Thread.Sleep(2000);
                    }

                    if (betAmount < 1 || betAmount > playerBalance)
                    {
                        Console.WriteLine($"Invalid bet amount. Please bet between $1 and your current balance. (${playerBalance})");
                    }
                    else
                    {
                        break;
                    }
                }

                ResetGame();
                DisplayHands();

                // Function to check if the player already has a blackjack
                if (CalculateScore(playerHand) == 21)
                {
                    Console.WriteLine($"BLACKJACK! {player.Nickname} wins!");
                    playerBalance += betAmount * 1.5; // Payout for blackjack (1.5 times the bet)
                    continue;
                }

                // Player's turn
                while (true)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine($"{player.Nickname}'s turn: (H)it or (S)tand?");
                    string choice = Console.ReadLine().ToUpper(); 

                    switch (choice)
                    {
                        case "H":
                            playerHand.Add(deck[0]);
                            deck.RemoveAt(0);
                            DisplayHands();
                            if (CalculateScore(playerHand) >= 21)
                            {
                                break;
                            }
                            break;

                        case "S":
                            break;

                        default:
                            Console.WriteLine("\n");
                            Console.WriteLine("Invalid input. Enter 'H' for Hit or 'S' for Stand.");
                            break;
                    }
                    if (choice == "S" || CalculateScore(playerHand) >= 21)
                    {
                        break;
                    }
                }

                if (CalculateScore(playerHand) <= 21)
                {
                    // Dealer's turn
                    while (CalculateScore(dealerHand) < 17)
                    {
                        dealerHand.Add(deck[0]);
                        deck.RemoveAt(0);
                    }
                    DisplayHands(true);

                    int playerScore = CalculateScore(playerHand);
                    int dealerScore = CalculateScore(dealerHand);

                    if (dealerScore > 21) Console.WriteLine("Dealer busts!");

                    if (dealerScore > 21 || playerScore > dealerScore)
                    {

                        if (playerScore == 21)
                        {    
                            Console.WriteLine("BLACKJACK!");
                            playerBalance += betAmount * 1.5; // Payout for blackjack (1.5 times the bet)
                        } 
                        else playerBalance += betAmount;
                        Console.WriteLine($"{player.Nickname} wins!");
                        
                    }
                    else if (playerScore < dealerScore)
                    {
                        Console.WriteLine("Dealer wins!");
                        playerBalance -= betAmount;
                    }
                    else 
                    {
                        if (playerScore==21) Console.WriteLine("BLACKJACK!");
                        Console.WriteLine("Tie!");
                    }
                }

                else
                {
                    Console.WriteLine($"{player.Nickname} busts. Dealer wins!");
                    playerBalance -= betAmount;
                }
            }
            Console.WriteLine("You're out of money. (real) Thank you for playing!");
            Console.ReadKey();
        }
    }
}


    

