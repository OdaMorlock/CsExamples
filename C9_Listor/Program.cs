using System;
using System.Collections.Generic;

namespace C9_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            bool _hasSiblings;
            Console.Write("Do you have any siblings (Yes/No)");
            var _siblingsResponse = Console.ReadLine();

            switch (_siblingsResponse.ToLower())
            {
                case "yes":
                    _hasSiblings = true;
                    break;

                case "no":
                    _hasSiblings = false;
                    break;

                default:
                    _hasSiblings = false;
                        break;
            }

            if (!_hasSiblings)
            {
                Console.WriteLine("OKay,Good for you");
            }
            else
            {
                Console.Write("Sorry too hear, How many sibings do you have? ");
                int _numberOfsiblings = Convert.ToInt32(Console.ReadLine());

                var siblings = new List<string>();

                if(_numberOfsiblings == 1)
                {
                    Console.Write("What is your siblings name?");
                    siblings.Add(Console.ReadLine());

                    Console.WriteLine($"Okay, so your siblings name is {siblings[0]}");
                }
                else
                {
                    Console.Write("What´s your sibings Names? Seperate by comma(,) ");
                    var _response = Console.ReadLine();

                    var names = _response.Replace(" ", "").Split(",");

                    foreach(var name in names)
                    {
                        siblings.Add(name);
                    }

                    Console.Write("Which of your sibings are the oldest one? ");
                    var _oldest = Console.ReadLine();

                    var index = siblings.FindIndex(x => x.Contains(_oldest));
                    siblings.RemoveAt(index);
                    siblings.Insert(0,_oldest);

                    Console.Write($"Okay, so your sibings names are ");
                    foreach(var sibling in siblings)
                    {
                        Console.Write($"{sibling} ");
                    }
                }

            }

        }
    }
}
