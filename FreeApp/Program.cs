using System;

namespace FreeApp
{
    class Program
    {

        static void Main(string[] args)
        {
            string color,
                   pluralNoun,
                   celebrity;


            Console.Write("MadLib\n");

            Console.Write("Enter a color. ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun. ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity name. ");
            celebrity = Console.ReadLine();



            Console.WriteLine($"Roses are { color }. ");
            Console.WriteLine($"{ pluralNoun } are ubiquitous. ");
            Console.WriteLine($"I love { celebrity }. ");
        }
    }
}