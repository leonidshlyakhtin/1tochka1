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
            double s = 0;
            Console.WriteLine("Введите значение y:");
            double y =
            Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение x:");
            double x =
            Convert.ToDouble(Console.ReadLine());
            s = 9.756 * Math.Pow(y, 7) + 2 *
            Math.Tan(x);
            Console.Write("s = " + "{0:0.00}", s);
            Console.ReadKey();
        }
    }
}