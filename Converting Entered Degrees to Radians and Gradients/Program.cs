using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application5
{
    class Program
    {
        static void Main(string[] args)
        {
            double degree,radyan,gradyan;
            double pi = 3.14;
            Console.Write("Dönüştürmek istediğiniz dereceyi giriniz.");
            degree = Convert.ToDouble(Console.ReadLine());

            radyan = degree * pi / 180;
            gradyan = 400 * degree / 365;
            Console.WriteLine("Girilen derecenin Gradyanı : " + gradyan + ", Radyanı : " + radyan);
            Console.ReadKey();
        }
    }
}
