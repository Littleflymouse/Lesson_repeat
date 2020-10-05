using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        public static int SumNum(int a)
        {
            int result = 0;
            while (a != 0)
            {
                result += a % 10;
                a /= 10;
            }
            
            return result;


        }
    
    
        static void Main(string[] args)
        {

            //Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000.
            //Хорошим называется число, которое делится на сумму своих цифр.
            //Реализовать подсчет времени выполнения программы, используя структуру DateTime.
            DateTime date1 = DateTime.Now;
            Console.WriteLine(date1.ToLongTimeString());
            int answer = 0;
            for (int i = 1; i <= 1000000000; i++)
            {
                if(i%SumNum(i) == 0)
                {
                    answer += i;
                }
            }
            
            Console.WriteLine(answer);
            DateTime date2 = DateTime.Now;
            Console.WriteLine(date2.ToLongTimeString());            
            Console.WriteLine($"Время выполнения: {date2.Subtract(date1)}");
            Console.ReadKey();
        }
    }
}
