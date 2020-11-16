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
            string word;
            int i;
            Console.Write("Enter a word : ");
            word = Console.ReadLine();
            int lenght = word.Length;
            char[] dizi = new char[lenght];
            for (i = 0; i < lenght; i++)
            {
                dizi[i] = word[i];
            }
            Array.Sort(dizi);
            Console.WriteLine("****************************************");
            Console.Write("In alphabetical order :");
            for (i = 0; i < lenght; i++)
            {
                Console.Write(dizi[i]);
            }
            Console.ReadLine();
        }
    }
}
