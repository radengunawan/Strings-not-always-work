using System;

namespace Strings_not_always_work
{
    class Program
    {
        static void Main(string[] args)
        {
            Kartu aceOfSpades = new Kartu("Ace", "Spades");
            Console.WriteLine(aceOfSpades);

            Console.Write("aceOfSpades.Name = ");
            Console.WriteLine(aceOfSpades.Name);

            Console.Write("aceOfSpades.Suit = ");
            Console.WriteLine(aceOfSpades.Suit);


        }
    }
}
