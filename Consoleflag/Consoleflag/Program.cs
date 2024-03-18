using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleflag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(29, 9);
            Console.WriteLine("                ");
            Console.SetCursorPosition(29, 10);
            Console.WriteLine("                ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.SetCursorPosition(29, 11);
            Console.WriteLine("                ");
            Console.SetCursorPosition(29, 12);
            Console.WriteLine("                ");
            Console.ReadKey();
        }
    }
}
