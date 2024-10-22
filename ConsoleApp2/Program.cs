using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Сколько вы хотите сложить чисел? (2 или 3)?: ");
            int a = int.Parse(Console.ReadLine());

            if (a != 2 && a != 3)
            {
                Console.Write("Неверное значение.");
                Console.ReadKey();
            }

            if (a == 2)
            {
                Console.WriteLine("Введите два числа для суммы:");
                Console.Write("Первое число:");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Второе число:");
                double num2 = Convert.ToDouble(Console.ReadLine());
                double sum2 = num1 + num2;
                Console.WriteLine($"Сумма двух чисел: {sum2}");
                Console.ReadKey();
            }

            if (a == 3)
            {
                Console.WriteLine("Введите три числа для суммы:");
                Console.Write("Первое число:");
                double num3 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Второе число:");
                double num4 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Третье число:");
                double num5 = Convert.ToDouble(Console.ReadLine());
                double sum3 = num3 + num4 + num5;
                Console.WriteLine($"Сумма трех чисел: {sum3}");
                Console.ReadKey();
            }
        }
    }
}