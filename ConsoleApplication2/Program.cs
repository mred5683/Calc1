using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, i am a calculator.\n");
            Console.WriteLine("input the first number you would like to calculate then press enter......\n");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("input the second number you would like to calculate then press enter.....\n");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose an operation and press enter.....\n");
            Console.WriteLine("1-addition\n");
            Console.WriteLine("2-subtraction\n");
            Console.WriteLine("3-multiplication\n");
            Console.WriteLine("4-division\n");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

        switch (z)
        {
                case 1:
                    Console.WriteLine(x + y);
                        Console.WriteLine("\n");
                     break;
                case 2:
                    Console.WriteLine(x - y);
                        Console.WriteLine("\n");
                        break;
                case 3:
                    Console.WriteLine(x * y);
                        Console.WriteLine("\n");
                        break;
                case 4:
                    Console.WriteLine(x / y);
                        Console.WriteLine("\n");
                        break;                    
        }

            
        }
    }
}
