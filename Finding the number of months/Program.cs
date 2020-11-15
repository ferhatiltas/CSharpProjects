using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application4
{
    class Program
    {
        static void Main(string[] args)
        {
            String monthName;
            Console.Write("Please enter a month name : ");
            monthName = Console.ReadLine();
            switch (monthName)
            {
                case "January": Console.Write("January is the 1st month.");break;
                case "February": Console.Write("February is the 2nd month.");break;
                case "March": Console.Write("March is the 3rd month.");break;
                case "April": Console.Write("April is the 4th month.");break;
                case "May": Console.Write("May is the 5th month.");break;
                case "June": Console.Write("June is the 6th month.");break;
                case "July": Console.Write("July is the 7th month.");break;
                case "August": Console.Write("August is the 8th month.");break;
                case "September": Console.Write("September is the 9th month.");break;
                case "October": Console.Write("October is the 10th month.");break;  
                case "November": Console.Write("November is the 11th month.");break;
                case "December": Console.Write("December is the 12th month.");break;
                default: Console.WriteLine("You entered it wrong."); break;
            }
            Console.ReadKey();
        }
    }
}
