using System;
using System.Collections.Generic;
using System.Text;

namespace C6__GettersAndSetters
{
    class Person
    {

        public string Name { get;private set; }

        public int Age => CalculateAge();

        public string City { get; set; }

        public DateTime DateOfBirth { get; set; }

        


        public void AskForName()
        {
            Console.Write("WELCOME MORTAL WHAT`S YOU´R NAME? ");

            Name = Console.ReadLine();

            Console.Write($"{Name}?! WHAT AT PATHETIC NAME UNLIKE MINE!");


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

      /*  public void AskForAge()
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

                    Console.WriteLine("GOD YOU´R STUPIDITY IS HURTING MY BRAIN!!!");

                }

            }

            finally
            {
                Console.WriteLine($"YOU´VE MERELY BEEN AROUND FOR {Age} YEARS AND YOU DARE TOO APPROACH ME!?!! ");


            }



        } */

        public void AskForDateOfBirth()
        {
            Console.Write("When Were You Born? "  );
            try
            {
                DateOfBirth = Convert.ToDateTime(Console.ReadLine());

            }

            catch
            {
                Console.Write("Write Date Year/Month/Day");

                try
                {
                    DateOfBirth = Convert.ToDateTime(Console.ReadLine());

                }

                catch
                {
                    Console.Write("You Dumb");
                }
            }
            Console.WriteLine($"Your Age {CalculateAge()} ");

        }

        private int CalculateAge()
        {
           int _age = DateTime.Now.Year - DateOfBirth.Year;
            if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
            {
                _age = _age - 1;
            }
            return _age;
        }

    }
}
