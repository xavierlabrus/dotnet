using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            object ob = number;
            int second = (int)ob;
        }
    }
}
