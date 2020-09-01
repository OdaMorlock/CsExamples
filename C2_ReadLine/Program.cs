using System;

namespace C2_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "";

            int age = 0;

            Console.Write("WELCOME MORTAL WHAT`S YOU´R NAME?");
             name = Console.ReadLine();

            Console.Write($"AND HOW FEW YEARS HAVE YOU`R EXISTENS BEEN {name}?");
            //int age = Convert.ToInt32(Console.ReadLine());

            try
            {

               age = Convert.ToInt32(Console.ReadLine());

            }

            catch
            {

                Console.WriteLine("ARE YOU EVEN UNCAPABLE OF TELLING YOUR LIFE IN DIGIT FORMAT?? DONT WORRY YOU WILL GET ONE! MORE CHANCE BETTER GET IT ");
                age = Convert.ToInt32(Console.ReadLine());

                try
                {

                    age = Convert.ToInt32(Console.ReadLine());

                }
                catch 
                {

                    Console.WriteLine("GOD YOU´R STUPIDITY IS HURTING MY BRAIN!!!");
                    
                }

            }

            finally
            {
                Console.WriteLine($"YOU´VE MERELY BEEN AROUND FOR {age} YEARS AND YOU DARE TOO APPROACH ME!?!! ");


            }
            Console.WriteLine($"UNLIKE MY NAME WITH 88 CHARACTERS YOUR NAME IS MERELY {name.Length} CHARACTERS LONG " );

        }
    }
}
