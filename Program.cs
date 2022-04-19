using System;

namespace Part_6__Random_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double valMin;
            double valMax;

            Random rnd = new Random();

            double.TryParse(Console.ReadLine(), out valMin);
            double.TryParse(Console.ReadLine(), out valMax);
            double Number = rnd.Next(valMin, valMax);
        }
    }
}
