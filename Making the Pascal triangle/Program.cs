using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of lines : ");
            int line = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < line; i++)
            {
                int c = 1;
                for (int e = 0; e < line - i; e++)
                {
                    Console.Write("   ");
                }
                for (int x = 0; x <= i; x++)
                {
                    Console.Write("    {0} ", c);
                    c = c * (i - x) / (x + 1);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
