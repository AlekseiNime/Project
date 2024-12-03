using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите радиус: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Calculate(radius);
            Console.ReadKey();
        }
        static void Calculate(double radius)
        {

            double area = Math.PI * radius * radius;

            double cir = 2 * Math.PI * radius;


            Console.WriteLine($"Радиус круга: {radius}");
            Console.WriteLine($"Площадь круга: {area}");
            Console.WriteLine($"Длина окружности: {cir}");
        }


    }   
}
