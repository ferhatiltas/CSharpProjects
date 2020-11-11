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
            int day, month, year;
            Console.Write("Enter your birthday. Example: 11 = ");
            day = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter your month of birth. Example: 11 = ");

            month = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter your year of birth. Example: 1111 = ");

            year = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Your date of birth : " + day + "." + month + "." + year);
            switch (month)
            {
                case 01: Console.Write("Month of Birth: January"); break;
                case 02: Console.Write("Month of Birth: February"); break;
                case 03: Console.Write("Month of Birth: March"); break;
                case 04: Console.Write("Month of Birth: April"); break;
                case 05: Console.Write("Month of birth: May"); break;
                case 06: Console.Write("Month of Birth: June"); break;
                case 07: Console.Write("Month of birth: July"); break;
                case 08: Console.Write("Month of birth: August"); break;
                case 09: Console.Write("Month of Birth: September"); break;
                case 10: Console.Write("Month of Birth: October"); break;
                case 11: Console.Write("Month of Birth: November"); break;
                case 12: Console.Write("Month of birth: December"); break;
                default: Console.WriteLine("You entered the wrong month number. Try again..."); break;
            }

            Console.ReadKey();
        }
    } 
    
}
