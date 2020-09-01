using System;

namespace C8_Arrys
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How any siblings do you have? ");
            var _numberOfSibings = Convert.ToInt32(Console.ReadLine());

            if (_numberOfSibings < 1)
                Console.WriteLine("Okay. That´s good for you! ");

            else
            {

                string[] siblings = new string[_numberOfSibings];

                if (_numberOfSibings == 1)
                {
                    Console.Write("What´s your siblings Name? ");
                    siblings[0] = Console.ReadLine();
                }
                else
                {
                    for(var i=0; i<_numberOfSibings; i++)
                    {
                        if (i == 0)
                        {
                            Console.Write("What´s your first siblings name? ");
                        }
                        else
                        {
                            Console.Write("And your next siblings name? ");
                        }
                        siblings[i] = Console.ReadLine();
                        
                    }

                }

                if(_numberOfSibings == 1)
                {
                    Console.Write("so correct me if i´m wrong. your sibings is ");
                }

                else
                {
                    Console.Write("so correct me if i´m wrong. your sibings are ");
                }

                foreach (var sibling in siblings)
                {
                    Console.Write($"{sibling} ");
                }


            }

        }
    }
}
