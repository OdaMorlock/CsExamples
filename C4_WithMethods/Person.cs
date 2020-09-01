using System;
using System.Collections.Generic;
using System.Text;

namespace C4_WithMethods
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        



        public void AskForName()
        {

            Console.Write("WELCOME MORTAL WHAT`S YOU´R NAME?");
            Name = Console.ReadLine();

            Console.Write($"AND HOW FEW YEARS HAVE YOU`R EXISTENS BEEN {Name}?");

        }


    }
}
