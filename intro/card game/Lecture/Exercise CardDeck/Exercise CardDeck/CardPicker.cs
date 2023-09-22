using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsCardPicker
{

    //create cardpicker class with 3 methods.
    class CardPicker
    {
        static Random Random = new Random();// random number generation from random class. 


        //method to pick cards: MAINMETHOD that calls the other two.  
            //- parameter "numberOfCards" is given by the user. 
            //- static makes intantiation unnecessary. 
        public static string[] PickSomeCard(int numberOfCards)
        {
            //array to hold the cards picked. Number of cards = position in array.  
            string[] pickedcards  = new string[numberOfCards];
            //loop through deck.
            for (int i = 0; i < numberOfCards; i++)
            {
                //assign card to array. 
                pickedcards[i] = RandomValue() + " of " + RandomSuit();
            }
            //return array. 
            return pickedcards;
        }



        //generate random suit. 
        private static string RandomSuit()
        {
            int value = Random.Next(1,5);//from 1 to 4 because of the number of suits in a deck of cards. 5 because max is excluded.
            if (value == 1) return "Spades";
            if (value == 2) return "Hearts";
            if (value == 3) return "Clubs";
            return "Diamonds";
            //no time for if_elseif_elseif_else. 
                                    
        }


        //generate random value. 
        private static string RandomValue()
        {
            int value = Random.Next(1,14); //same thing but larger range.
            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();//converts value to string before passing it. 
        }
    }
}
