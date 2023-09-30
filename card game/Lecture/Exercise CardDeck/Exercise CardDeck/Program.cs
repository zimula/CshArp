using System.Buffers.Text;
using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace Exercise_CardDeck
{
    internal class Program
    {

        static void Main(string[] args)
        {
            CardDeck cardDeck = new CardDeck();
            cardDeck.PrintAllCards();
            Console.WriteLine();
        }
    }
}