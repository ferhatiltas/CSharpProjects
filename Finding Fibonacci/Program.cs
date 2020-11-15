using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 1, z;
            int number;

            Console.Write("How many Fibonacci numbers do you want to see? : ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.Write(x  + " " + y + " ");

            for (int i = 0; i < number - 2; i++)
            {
                z = x + y;
                Console.Write(z+" ");
                x = y;
                y = z;

            }

            Console.ReadKey(); 
        }
    }
}
