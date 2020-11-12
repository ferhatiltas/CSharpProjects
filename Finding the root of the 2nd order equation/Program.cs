using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x, determinant, x1 ,x2;
        
            Console.Write("Enter the number a : ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the number b : ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the number c : ");
            c = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Quadratic equation created : " + (a+"x^2 + "+b+"*x "+"+ "+c));

            determinant = (b * b) - (4 * a * c);
            double determinantSqrt = Math.Sqrt(determinant);
            if ( determinant > 0)
            {
                Console.WriteLine("Roots : x1 != x2 there are two different real roots.");
                x1 = ((-b) + (determinantSqrt)) / (2 * a);
                x2 = ((-b) - (determinantSqrt)) / (2 * a);
                Console.WriteLine("Roots : x1 = " + x1 + ", x2 = " + x2);
            }
            else if (determinant < 0)
            {
                x = +Math.Sqrt((-c) / a);
                x = -Math.Sqrt((-c) / a);
                Console.WriteLine("Roots are symmetrical, there is no real root.");
            }
            else if (c == 0)
            {
                Console.Write(a + "x^2 " + "+" + b + "x = 0");
                Console.WriteLine("Roots : " + "x1 = 0 " + "x2 = " + (-b / a));
            }
            else if ( determinant==0)
            {
                Console.WriteLine("There are two overlapping roots. Roots : x1 = x2 = 0 ");
            }
            Console.ReadKey();
        }
    }
}
