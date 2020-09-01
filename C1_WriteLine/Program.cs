using System;

namespace C1_WriteLine
{
    class Program
    {
        static void Main(string[] args)
        {


            String name = " Marcus";
            int age = 25;
            var city = "Hidingebro/Fjugesta";


            var text1 = $"Welcome {name} , You are {age} years old right? {name} do you live in {city}?";

            Console.WriteLine(text1);

        }
    }
}
