using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double L, a, b, c;
                Console.WriteLine("Введите число a");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите число b");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите число c");
                c = double.Parse(Console.ReadLine());
                L = (1 / b + c) * Math.Sqrt((b * c) * (a + b + c) * (b + c - a));
                Console.WriteLine("L=" + L);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
