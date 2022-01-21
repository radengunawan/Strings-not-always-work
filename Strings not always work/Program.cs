using System;
using System.Collections.Generic;

namespace Strings_not_always_work
{
    class Program
    {
        enum Suits { Diamonds, Clubs, Hearts, Spades, Shelby }
        
        static void Main(string[] args)
        {
            Suits mySuit = Suits.Diamonds;

            Suits[] myVals = new Suits[3]
            {
                Suits.Spades,
                Suits.Clubs,
                mySuit
            };

            //string aaa = Suits.Diamonds.ToString();
            //var bbb = Suits.Diamonds;


            //int count = Enum.GetValues(typeof(Suits)).Length;
            var abvc = Suits.Hearts;

            IsItAHeart(abvc);

        } //end Main method

        static void IsItAHeart(Suits suit)
        {
            if (suit == Suits.Hearts)
                Console.WriteLine("Heart pulled");
            else
            {
                Console.WriteLine($"You didn't pull a heart: {suit.ToString()}");
            }
        } //END method 2

    } //END class
    }

