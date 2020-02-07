using System;

namespace FreeApp
{
    class Program
    {

        static void Main(string[] args)
        {
            double number1,
                   number2,
                   sum;


            Console.Write("Basic Calculator\n");

            Console.Write("Enter a number. ");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number. ");
            number2 = Convert.ToDouble(Console.ReadLine());

            sum = number1 + number2;

            Console.WriteLine($"The answer { sum }, Cheers!. ");
        }
    }
}