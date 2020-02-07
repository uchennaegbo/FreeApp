using System;

namespace FreeApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Hi, what's your name? ");
            string name = Console.ReadLine();

            Console.Write($"How old are you, {name}? ");
            var age = Console.ReadLine();


            Console.WriteLine($"Welcome {name}, You are {age} years old. ");
        }
    }
}