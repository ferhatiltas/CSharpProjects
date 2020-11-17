using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1
{

    class Calculator
    {
        
        int n1, n2;
        string operationType;
        public Calculator()
        {
            Console.WriteLine("Creating a class object...");

            Console.Write("Enter the first number : ");
            n1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter the seconder number : ");
            n2 = Convert.ToInt16(Console.ReadLine());

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
            n1 = d;
        }
        public void gets2(int e)
        {
            n2 = e;
        }
        public void getİslemTipi(string f)
        {
            operationType = f;
        }

        public void Additional()
        {
            int additional = n1 + n2;
            Console.Write("Sum of numbers entered : " + additional);
        }
        public void Difference()
        {
            int difference = n1 - n2;
            Console.Write("Difference in numbers entered : " + difference);
        }
        public void Multiplication()
        {
            int multiplication = 0;
            for(int i = 1; i <= n2; i++)
            {
                multiplication = n1 + multiplication;
            }
            Console.Write("The product of the numbers entered : " + (multiplication)); ;
        }
        public void Division()
        {
            int result, counter;
            result = n1;

            for (counter = 0; n2 < 1+ result; counter++)
            {
                result = result - n2;
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
