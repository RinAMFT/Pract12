using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        /// <summary>
        ///  Рассчитать значение z=min(2a,b+a)+min(2a-b,b)
        /// </summary>
        /// <param name="args"></param>
        static int Min(int a, int b)
        {
            return (a < b) ? a : b;
        }
        static int Function(int a, int b)
        {
            return Min(2 * a, b + a) + Min(2 * a - b, b);
        }
        static int InPut(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void OutPut(int z)
        {
            Console.WriteLine($"z = {z}");
        }
        static void Main(string[] args)
        {
            int a = InPut("Введите первое число: ");
            int b = InPut("Введите второе число: ");
            int z = Function(a, b);
            OutPut(z);
            Console.ReadKey();
        }      
    }
}
