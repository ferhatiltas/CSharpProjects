using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            long number ;

            CheckTheNumber(out number);

            CollectTheFigures(number);
           
            Console.ReadKey();
            
        }

        public static void CollectTheFigures(long n)
        {
            long result = 0;
            
            while (n > 0)
            {
                result += (n % 10);
                n = n / 10;
            }
            Console.WriteLine("\n Sum of digits entered : " + result);

            int num = 1;
            int count = 0;
            
            while (true)
            {
                num++;
                if (CalculateThePrimeNumber(num))
                {
                    count++;
                }
                if (count == result)
                {
                    Console.WriteLine(" Your prime number : " + num);
                    Console.Write(" ========> Your password : " + num);

                    break;
                }
            }

            CalculateFibonacci(ref result);
        }

        public static bool CalculateThePrimeNumber(int n)
        {
            int counter = 0;
            for (int j = 2; j < n; j++)
            {
                if (n % j == 0)
                {
                    counter = 1;
                    break;
                }
            }
            if (counter == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void CalculateFibonacci(ref long n)
        {
            
        
            long num = n; 
            long[] fib = new long[num + 1];
            fib[0] = 0;
            fib[1] = 1;
            for (int i = 2; i <= num; i++)
            {
                fib[i] = fib[i - 2] + fib[i - 1];
            }
            Console.Write(fib[num]);
            Console.Write(" <========");
            Console.WriteLine(" \n Your Fibonacci number : " + fib[num]);
            
        }

        public static void CheckTheNumber(out long n)
        {
            Console.Write(" Please enter your 10-digit mobile phone number. : ");
            n = Convert.ToInt64(Console.ReadLine());

            long a = Convert.ToInt32(n / 1000000000);
            if (n.ToString().Length != 10 && a != 5)
            {
                
                Console.Write(" Please enter a number that is 10 carats long and starts with 5. \n Try again.");
                Console.ReadLine();
            }
            else
            {
                Console.Write(" Your number : "+n);
            }
        }

       
    }
}
