using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("Please enter the x value : ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the y value : ");
            y = Convert.ToDouble(Console.ReadLine());
            double s = x / y;
            Console.WriteLine("x + y : " + (x + y));
            Console.WriteLine("x - y : " + (x - y));
            Console.WriteLine("x * y : " + (x * y));
            Console.WriteLine("x / y : " + (x / y));

            Console.WriteLine("Press any key to exit the program...");

            Console.ReadKey();
        }
    }
}
