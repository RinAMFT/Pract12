using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        /// <summary>
        ///  Рассчитать значение y, определив и используя статический метод
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine($"{Function(15, 8) + Function(6, 12) + Function(7, 21):F2}");
            Console.ReadKey();
        }
        static double Function(int y, int x)
        {
            return (y + Math.Sqrt(x)) / (x + Math.Sqrt(y));
        }
    }
}
