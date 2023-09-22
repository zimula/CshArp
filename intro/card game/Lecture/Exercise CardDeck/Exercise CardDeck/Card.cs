using Exercise_CardDeck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_CardDeck
{
    //card class
    internal class Card
    {
        Color color;
        Rank rank;
        public Card(Color color, Rank rank)
        {
            this.color = color;
            this.rank = rank;
        }
        public override string ToString()
        {
            //string str = String.Format("{0} {1}", color, rank);
            string str = String.Format($"{color} {rank}");
            return str;
        }
    }
}
