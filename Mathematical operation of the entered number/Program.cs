using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1
{

    class Calculator
    {
        
        int k, l;
        string operationType;
        public Calculator()
        {
            Console.WriteLine("Creating a class object...");

            Console.Write("Enter the first number : ");
            k = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter the seconder number : ");
            l = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter the arithmetic operation type. Example: (addition, subtraction, multiplication, division) : ");
            operationType = Console.ReadLine();
            switch (operationType)
            {
                case "addition": Additional(); break;
                case "subtraction": Difference(); break;
                case "multiplication": Multiplication(); break;
                case "division": Division(); break;
                default: Console.WriteLine("You entered it wrong. \n Please try again.");break;
            }
        }
        public void gets1(int d)
        {
            k = d;
        }
        public void gets2(int e)
        {
            l = e;
        }
        public void getİslemTipi(string f)
        {
            operationType = f;
        }

        public void Additional()
        {
            int additional = k + l;
            Console.Write("Sum of numbers entered : " + additional);
        }
        public void Difference()
        {
            int difference = k - l;
            Console.Write("Difference in numbers entered : " + difference);
        }
        public void Multiplication()
        {
            int multiplication = 0;
            for(int i = 1; i <= l; i++)
            {
                multiplication = k + multiplication;
            }
            Console.Write("The product of the numbers entered : " + (multiplication)); ;
        }
        public void Division()
        {
            int result, counter;
            result = k;

            for (counter = 0; l < 1+ result; counter++)
            {
                result = result - l;
            }
            Console.WriteLine("Division of numbers you entered : " + counter);
            Console.WriteLine("Remnant from the episode : " + result);
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.ReadKey();
        }


    }
    
}
