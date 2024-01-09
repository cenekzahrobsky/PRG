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

        public Player()
        {
            Hand = new List<Card>();
            Score = 0;
        }

        public void CalculateScore()
        {
            Score = Hand.Sum(card => card.Value);
            if (Score > 21)
            {
                foreach (var card in Hand.Where(card => card.Face == "A"))
                {
                    Score -= 10;
                    if (Score <= 21)
                        break;
                }
            }
        }
    }
}
