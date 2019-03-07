using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class HelloWorld
    {
        static public void Print(string arg = " No args!") => Console.WriteLine("Hello world!" + arg);
        static void Main(string[] args)
        {
            if (args.Length == 0) Print();
            else foreach (string arg in args) Print(arg);
            Console.Read();
        }
    }
}
