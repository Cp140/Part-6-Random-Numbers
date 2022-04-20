using System;

namespace Part_6__Random_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int valMin;
            int valMax;
            int loopCount;

            loopCount = 25;
            Random rnd = new Random();

            Console.WriteLine("This program generartes 25 random numbers with in a enter number range");
            Console.WriteLine("     ----------      ");
            Console.WriteLine("enter a minimum value");
            int.TryParse(Console.ReadLine(), out valMin);
            Console.WriteLine("Enter a Maximum number");
            int.TryParse(Console.ReadLine(), out valMax);
            Console.WriteLine("--------------------");
            for (int i = 1; i <= loopCount; i++)
            {

                
                double number = rnd.Next(valMin, valMax);
                Console.WriteLine($"{number}");
            }
            Console.WriteLine("--------------------");

        }
    }
}
