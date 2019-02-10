using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(5.multiple(3));
            Console.ReadKey();
        }
    }

    static class IntegerExtensiveMethods
    {
        public static int multiple(this int valor, int multi)
        {
            return valor * multi;
        }
    }
}
