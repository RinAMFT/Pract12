using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        /// <summary>
        /// Определить статический метод int Kop (int r, int k); Task2
        /// </summary>
        /// <param name="args"></param>
        static int Kop(int r, int k)
        {
            return r * 100 + k;
        }
        static int InPut(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void OutPut(int res)
        {
            Console.WriteLine($"Результат: {res}");
        }
        static void Main(string[] args)
        {
            int r = InPut("Введите число рублей: ");
            int k = InPut("Введите число копеек: ");
            int res = Kop(r, k);
            OutPut(res);
            Console.ReadKey();
        }
    }
}
