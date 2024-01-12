using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackSch
{
    internal class Player
    {
        public List<Card> Hand { get; set; }
        public int Score { get; set; }
        public string Nickname { get; set; }

        public Player()
        {
            Hand = new List<Card>();
            Score = 0;
            Nickname = GetPlayerNickname();
        }
        private string GetPlayerNickname()
        {
            Console.WriteLine("Welcome to the Blackjack game!");
            Console.Write("Enter your nickname: ");
            return Console.ReadLine();
        }
    }
}
