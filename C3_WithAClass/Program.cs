using System;

namespace C3_WithAClass
{
    class Program
    {
        static void Main(string[] args)
        {

            var person = new Person();
            var person2 = new Person();

            Console.Write("WELCOME MORTAL WHAT`S YOU´R NAME?");
            person.Name = Console.ReadLine();
            
            Console.Write($"AND HOW FEW YEARS HAVE YOU`R EXISTENS BEEN {person.Name}?");
            

            try
            {

                person.Age = Convert.ToInt32(Console.ReadLine());

            }

            catch
            {

                Console.WriteLine("ARE YOU EVEN UNCAPABLE OF TELLING YOUR LIFE IN DIGIT FORMAT?? DONT WORRY YOU WILL GET ONE! MORE CHANCE BETTER GET IT ");
                person.Age = Convert.ToInt32(Console.ReadLine());

                try
                {

                    person.Age = Convert.ToInt32(Console.ReadLine());

                }
                catch
                {

                    Console.WriteLine("GOD YOU´R STUPIDITY IS HURTING MY BRAIN!!!");

                }

            }

            finally
            {
                Console.WriteLine($"YOU´VE MERELY BEEN AROUND FOR {person.Age} YEARS AND YOU DARE TOO APPROACH ME!?!! ");


            }

            Console.WriteLine($"UNLIKE MY NAME WITH 88 CHARACTERS YOUR NAME IS MERELY {person.Name.Length} CHARACTERS LONG ");

            Console.Write($"WHERE DO YOU CALL HOME {person.Name} ?" );


            person.City = Console.ReadLine();

            Console.WriteLine($"I´VE NEVER HEARD OF {person.City} MUST BE AN HORRIBLE PLACE I´VE NEVER GRACED WITH MY PRESENCE");

        }
    }
}
