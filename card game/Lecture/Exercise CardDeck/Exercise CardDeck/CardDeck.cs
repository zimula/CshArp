using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_CardDeck
{
    //generate an entire deck of cards. 
    internal class CardDeck
    {
        List<Card> cards = new List<Card>();
        public CardDeck() 
        {
            foreach (int colorInt in Enum.GetValues(typeof(Color))) //iterer gennem alle Color
            {
                foreach (int rankInt in Enum.GetValues(typeof(Rank))) //iterer gennem alle Rank
                    cards.Add(new Card((Color)colorInt, (Rank)rankInt));
                {
                }
            }
        }
        public void PrintAllCards()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
            
        }
    }
}
