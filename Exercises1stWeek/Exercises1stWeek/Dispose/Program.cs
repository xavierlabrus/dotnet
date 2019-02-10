using System;
using System.IO;
using System.Text;

namespace Dispose
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream word = File.Create("test2.txt");
            try
            {
                Byte[] palabra = new UTF8Encoding(true).GetBytes("test2");
                word.Write(palabra, 0, palabra.Length);

            }
            catch
            {
                throw new FileNotFoundException("the file doesn't exists");
            }
            finally
            {
                word.Dispose();
            }
        }
    }
}
