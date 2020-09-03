using System;

namespace C10_Struct
{

    class ClassExample
    {
        public int Nr1 { get; set; }
        public int Nr2 { get; set; }
        public ClassExample(int nr1, int nr2)
        {
            Nr1 = nr1;
            Nr2 = nr1;
        }
        public void DisplayValues()
        {
            Console.WriteLine($"Display Values: {Nr1},{Nr2}");
        }
    }

    struct StructExample
    {
        public int Nr1 { get; set; }
        public int Nr2 { get; set; }
        public StructExample(int nr1, int nr2)
        {
            Nr1 = nr1;
            Nr2 = nr1;
        }
        public void DisplayValues()
        {
            Console.WriteLine($"Display Values: {Nr1},{Nr2}");
        }
    }







    class Program
    {

        private static void ModifyValues(dynamic d)
        {
            d.Nr1 += 1;
            d.Nr2 += 1;

            Console.WriteLine($"Modifying Values: {d.Nr1},{d.Nr2}");
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Class Example - HEAP (GLOBAL)");
            var classexemple = new ClassExample(1, 1);

            classexemple.DisplayValues();
            ModifyValues(classexemple);
            classexemple.DisplayValues();
            ModifyValues(classexemple);
            classexemple.DisplayValues();


            Console.WriteLine("\n--------------------------------------------------------\n");

            Console.WriteLine("StructExample - STACK (LOCAL)");
            var structexemple = new StructExample(1, 1);

            structexemple.DisplayValues();
            ModifyValues(structexemple);
            structexemple.DisplayValues();
            ModifyValues(structexemple);
            structexemple.DisplayValues();


            Console.ReadKey();
            {

            }

        }
    }
}
