using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repoq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            string tmp;
            string pause;
            Console.WriteLine("Введите число:");

            tmp = Console.ReadLine();
            year = Convert.ToInt32(tmp);
            Console.WriteLine($"Введенный год: {year}");

            if ((year % 4 == 0) && !(year % 100 == 0 && year % 400 != 0))
            {
                Console.WriteLine("Год високосный");
            }
            else
            {
                Console.WriteLine("Год не високосный");
            }
            Console.WriteLine("Конец");
            pause = Console.ReadLine();




        }
    }
 }

