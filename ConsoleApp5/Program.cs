using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vvod(ref a, ref b, ref c, ref d);
            Obmen(ref a, ref b, ref g, ref j, ref c, ref d);
        }
        static void Vvod(ref string a,ref string b,ref string c,ref string d)
        {
            Console.WriteLine("Введите 4 цифры");
             a = Console.ReadLine();
             b = Console.ReadLine();
             c = Console.ReadLine();
             d = Console.ReadLine();
        }
        static void Obmen(ref string a, ref string b, ref string g, ref string j, ref string c, ref string d)
        {
            a = g;
            b = a;
            g = b;
            c = j;
            d = c;
            j = d;
        }
        static void Vivod()
        {
            Console.WriteLine($"После {a} {b} {c} {d}");
        }
    }
}
