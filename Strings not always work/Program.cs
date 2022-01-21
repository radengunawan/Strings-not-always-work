using System;
using System.Collections.Generic;

namespace Strings_not_always_work
{
    class Program
    {
        enum Suits { Diamonds, Clubs, Hearts, Spades,  }
        
        static void Main(string[] args)
        {
            Suits mySuit = Suits.Diamonds;

            Suits[] myVals = new Suits[3]
            {
                Suits.Spades,
                Suits.Clubs,
                mySuit
            };

            int enum_length = Enum.GetValues(typeof(Suits)).Length; ;
            
            List<Suits> card1 = new List<Suits>();
            
            for (int i = 0; i < enum_length; i++)
            {
                card1.Add((Suits)i);
            }

            //Console.WriteLine(card1.Count);

            foreach (var item in card1)
            {
                var a = (Suits)item;
                var b = a.ToString();
                var c = a.GetType();
                var d = b.GetType();

                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(d);

                Console.WriteLine("");
            }
            

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

