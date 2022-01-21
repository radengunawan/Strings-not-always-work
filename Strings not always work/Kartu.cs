using System;
using System.Collections.Generic;
using System.Text;

namespace Strings_not_always_work
{
    class Kartu
    {
        public string Value { get; set; }

        public string Suit { get; set; }

        public string Name
        {
            get { return $"{this.Value} of {this.Suit}"; }
        }

        

        //constructor
        public Kartu (string value, string suit)
        {
            this.Value = value;
            this.Suit = suit;
        }

    }
}
