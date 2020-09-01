using System;
using System.Collections.Generic;
using System.Text;

namespace C5_WithAgeCalc
{
    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string City { get; set; }

        public DateTime DateOfBirth { get; set; }


        public void AskForName()
        {
            Console.Write("WELCOME MORTAL WHAT`S YOU´R NAME?");

            Name = Console.ReadLine();

            Console.Write($"{Name}!? WHAT A PATHETIC NAME UNLIKE MINE! ");

            
        }
        
        public void NameContains()
        {

            Console.WriteLine($"UNLIKE MY NAME WITH 88 CHARACTERS YOUR NAME IS MERELY {Name.Length} CHARACTERS LONG ");

        }

        public void AskForCity()
        {

            Console.Write($"WHERE DO YOU CALL HOME {Name} ?");


            City = Console.ReadLine();

            Console.WriteLine($"I´VE NEVER HEARD OF {City} MUST BE AN HORRIBLE PLACE I´VE NEVER GRACED WITH MY PRESENCE");

        }

        public void AskForAge()
        {

            Console.Write($"AND HOW FEW YEARS HAVE YOU`R EXISTENS BEEN {Name}?");

            try
            {
                Age = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ARE YOU EVEN UNCAPABLE OF TELLING YOUR LIFE IN DIGIT FORMAT?? DONT WORRY YOU WILL GET ONE! MORE CHANCE BETTER GET IT ");
                Age = Convert.ToInt32(Console.ReadLine());

                try
                {
                    Age = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("GOD YOU´R STUPIDITY IS HURTING ME!!!");
                }

            }
            finally
            {
                Console.WriteLine($"YOU´VE MERELY BEEN AROUND FOR {Age} YEARS AND YOU DARE TOO APPROACH ME!?!! ");
            }



        }

        public void AskForDateOfBirth()
        {
            Console.Write("When ere you born ?");
            try
            {
                DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            }
            catch
            {
                Console.Write("Write Date Year/Month/Day In Numerical 1,2,3,4,5");

                try
                {
                    DateOfBirth = Convert.ToDateTime(Console.ReadLine());
                }
                catch
                {
                    Console.Write("You Dumb");
                }
            }
            Console.WriteLine($"Your Age{CalculateAge()}");
        }

        private int CalculateAge()
        {
            Age = DateTime.Now.Year - DateOfBirth.Year;

            if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
            {
                Age = Age - 1;
            }

            return Age;
        }

    }
}
