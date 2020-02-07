using System;

namespace FreeApp
{
    class Program
    {
        private const char Value = '!';

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!".EndsWith(Value));
        }
    }
}