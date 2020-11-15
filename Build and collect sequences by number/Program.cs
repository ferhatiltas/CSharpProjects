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
            int n,s=0;
            int i = 1;
            int sonuc = 0;
            Console.Write("Please enter a number : ");
            int j = 1;
            n = Convert.ToInt16(Console.ReadLine());
            while( i <= n){
                
                while(j == i)
                {
                    for(int k = 1; k <= n; k++)
                    {
                        

                        Console.WriteLine(j+"  "+k);

                        s = j + k;
                        sonuc = sonuc + s;

                    }
                    j++;
                }
                i++;

            }
            Console.Write("Total cycles based on the number you entered : "+sonuc);

            Console.ReadKey();
        }
    }
}
