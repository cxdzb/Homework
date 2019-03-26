using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change the background color to Blue;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hello World!");

            //Change the background color to Green;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");

            //Reset the background color;
            Console.ResetColor();
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");

            Console.Read();
        }
    }
}
