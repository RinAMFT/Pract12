using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        /// <summary>
        /// Определить статический метод int Centimeters (int m, int c)
        /// </summary>
        /// <param name="args"></param>
        static int Centimeters(int m, int c)
        {
            return m * 100 + c;
        }
        static int InPut(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void OutPut(int res)
        {
            Console.WriteLine($"Результат: {res} cм");
        }
        static void Main(string[] args)
        {
            int m = InPut("Введите число метров: ");
            int c = InPut("Введите число сантиметров: ");
            int res = Centimeters(m, c);
            OutPut(res);
            Console.ReadKey();
        }

    }
}
