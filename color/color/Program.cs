using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace color
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("hello");
           /* Console.Clear(); */
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("hello");
            Console.ReadKey();
        }
    }
}
