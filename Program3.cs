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
            double x, y;
            Console.WriteLine("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());
            y = (2 * Math.Atan(Math.Sqrt(1 - (x * x))) + (Math.Log10(7 * x)) / 1 + Math.Exp(x));
            Console.WriteLine("Результат: {0}", y);
        }
    }
}
