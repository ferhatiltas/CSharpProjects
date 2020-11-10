using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application : 2 ");
            int s1, s2;

            Console.Write("Enter the first number : ");

            s1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter the second number : ");

            s2 = Convert.ToInt16(Console.ReadLine());
            if (s1 % s2 == 0)
            {
                Console.WriteLine(true);
            }
            else if (s2 % s1 == 0)
            {
                Console.WriteLine(true);
            }
            else Console.WriteLine(false);

            Console.ReadKey();
        }
    }
}
