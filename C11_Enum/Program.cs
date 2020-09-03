using System;

namespace C11_Enum
{


    public enum Level
    {
        Low,
        Normal,
        High
    }





    class Program
    {

         enum Status
        {
            Pending,
            Production,
            Transporting,
            Deliverd
        }


        static void Main(string[] args)
        {
            
            var _tempLevel = Level.Normal;

            var temperature = 32;

            switch (temperature)
            {
                case var t when t < 10:
                    {
                        _tempLevel = Level.Low;
                       
                        break;
                    }
                case var t when t > 30:
                    {
                        _tempLevel = Level.High;
                       
                        break;
                    }
                default:
                    {
                        _tempLevel = Level.Normal;
                        
                        break;
                    }

            }

            switch (_tempLevel)
            {

                case Level.Low:
                {
                     Console.WriteLine("Temeperature is to Low");
                        break;
                }
                case Level.Normal:
                {
                        Console.WriteLine("Temeperature is Normal");
                        break;
                }
                case Level.High:
                {
                        Console.WriteLine("Temeperature is to High");
                        break;
                }

            }


            var status = Status.Pending;

            switch (status)
            {

                case Status.Pending:
                    {
                        Console.WriteLine("Electronic information has been received.");
                        break;

                    }

                case Status.Production:
                    {
                        Console.WriteLine("Your production(s) are being prepared for shipping");
                        break;

                    }

                case Status.Transporting:
                    {
                        Console.WriteLine("Your product(s) are in transit.");
                        break;

                    }

                    case Status.Deliverd:
                    {
                        Console.WriteLine("Your product(s) has been deliverd.");
                        break;

                    }

            }



        }
    }
}
