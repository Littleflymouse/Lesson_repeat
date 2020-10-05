using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void NumInterval(int a, int b)
        {
            a++;
            Console.WriteLine(a);
            if(b-1>a)
            {
                NumInterval(a, b);
            }
                        
        }
        static int NumSum(int a, int b)
        {

            int result = a;            
            a++;
            if(a < b+1)
            {
                result += NumSum(a, b);
            }
            
            return result;
        }

        static void Main(string[] args)
        {
            //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b);
            //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

            int a, b;
            Console.Write("Enter the a: ");
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
            NumInterval(a, b);
            Console.WriteLine(b);
            Console.WriteLine($"Sum numbers between a and b: {NumSum(a,b)}");
            Console.ReadKey();

        }
    }
}
