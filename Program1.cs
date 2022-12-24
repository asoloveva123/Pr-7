using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число");

            //Вводим произвольное 3-х значное число (для примера 123)
            int digitNumber = Convert.ToInt32(Console.ReadLine());

            //Разбиваем число на базовые элементы
            int firstNumber = digitNumber / 100;
            int secondNumber = ((digitNumber - (digitNumber / 100) * 100)) / 10;
            int thirdNumber = digitNumber % 10;

            //123
            Console.WriteLine($"первое число = {firstNumber * 100 + secondNumber * 10 + thirdNumber}");
            //132
            Console.WriteLine($"второе число = {firstNumber * 100 + secondNumber + thirdNumber * 10}");
            //312
            Console.WriteLine($"третье число = {firstNumber + secondNumber * 10 + thirdNumber * 100}");
            //321
            Console.WriteLine($"четверное число = {firstNumber * 10 + secondNumber + thirdNumber * 100}");
            //213
            Console.WriteLine($"пятое число = {firstNumber * 10 + secondNumber * 100 + thirdNumber}");
            //231
            Console.WriteLine($"шестое число = {firstNumber + secondNumber * 100 + thirdNumber * 10}");
        }
    }
}