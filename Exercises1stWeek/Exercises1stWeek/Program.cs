using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises1stWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5.multiplication(3));
            Console.ReadKey();
        }
    }
    static class IntegerExtensiveMethods
    {
        public static int multiplication(this int valor, int multiplicador) {
            return valor * multiplicador;
        }
    }
}
