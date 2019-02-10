using System;
using System.Text;
using System.IO;

namespace Using
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream word = File.Create("test.txt"))
            {
                Byte[] palabra = new UTF8Encoding(true).GetBytes("test");
                word.Write(palabra, 0, palabra.Length);

            }
        }
    }
}
