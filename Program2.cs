using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double r1, r2, pi, s;
            Console.WriteLine("Введите значение r1: ");
            r1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение r2: ");
            r2 = Convert.ToDouble(Console.ReadLine());
            pi = 3.14;
            s = pi * ((r2 * r2) - (r1 * r1));
            Console.WriteLine("Результат: {0}", s);
        }
    }
}
