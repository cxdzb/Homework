using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld1
{
    public class HelloWorld
    {
        HelloWorld() => Console.Write("Hello world!");
        static void Main(string[] args)
        {
            HelloWorld hw = new HelloWorld();
            if (args.Length == 0) Console.WriteLine(" No args!");
            else foreach (string arg in args) Console.Write(" "+arg);
            Console.Read();
        }
    }
}
