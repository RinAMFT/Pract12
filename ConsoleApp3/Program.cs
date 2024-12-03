using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        /// <summary>
        /// Найти минимальное из трех целых чисел, используя вспомогательные методы 
        /// </summary>
        /// <param name="args"></param>
        static int Min(int a, int b, int c)
        {
            return Math.Min(a, Math.Min(b, c));
        }
        static int InPut(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void Output(int res)
        {
            Console.WriteLine($"Минимальное число: {res}");
        }
        static void Main(string[] args)
        {
            int a = InPut("Введите первое число: ");
            int b = InPut("Введите второе число: ");
            int c = InPut("Введите третье число: ");
            int res = Min(a, b, c);
            Output(res);
            Console.ReadKey();
        }
    }
}
