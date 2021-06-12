
using System;

namespace ActiviyQuestion1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;

            Console.WriteLine("pleasse enter a number1 if it is odd or even");
            number1 = Convert.ToInt32(Console.ReadLine());

            if (number1 % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }

    }
}
