using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            for (x = 1; x <= 10; x++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(x + "x" + i + "=" + (x * i).ToString());
                }
            }
            Console.ReadKey();
        }
    }
}
