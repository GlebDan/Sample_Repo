using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            float Number1, Number2;
            Console.WriteLine("Hello!");
            Console.WriteLine("Please type 2 different numbers - each on the new line, and press Enter key.\n");
            Number1 = float.Parse(Console.ReadLine());
            Number2 = float.Parse(Console.ReadLine());
            if (Number1 % Number2 == 0)
            { Console.WriteLine("The first entered number is divided on the second number without remainder.\n"); }
            else
            { Console.WriteLine("The first entered number is not divided on the second number without remainder.\n"); }
            Console.WriteLine("Press Enter key.\n");
            Console.ReadLine();
        }
    }
}
