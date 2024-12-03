using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        /// <summary>
        ///  Рассчитать значение y, определив и используя статический метод
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine($"y = {Function(5) + Function(12) + Function(19):F2}");
            Console.ReadKey();
        }
        static double Function(int y)
        {
            return (Math.Sqrt(y) + y) / 3;
        }

    }
}
