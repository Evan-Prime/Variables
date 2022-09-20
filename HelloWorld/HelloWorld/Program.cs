using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     +----+     ");
            Console.WriteLine("     |    |     ");
            Console.WriteLine("+----+----+----+");
            Console.WriteLine("| Hello World! |");
            Console.WriteLine("+----+----+----+");
            Console.WriteLine("     |    |     ");
            Console.WriteLine("     +----+     ");
            Console.WriteLine("");
            Console.WriteLine("Made by: Evan MacDonald");
            Console.WriteLine("Date: 2022-09-07");
            Console.WriteLine("");
            Console.Beep();
            Console.ReadKey(true);
        }
    }
}
