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
            int n1, n2;
            

            Console.Write("Enter the first number : ");

            n1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter the second number : ");

            n2 = Convert.ToInt16(Console.ReadLine());
            if (n1 % n2 == 0)
            {
                Console.WriteLine(true);
            }
            else if (n2 % n1 == 0)
            {
                Console.WriteLine(true);
            }
            else Console.WriteLine(false);

            Console.ReadKey();
        }
    }
}
