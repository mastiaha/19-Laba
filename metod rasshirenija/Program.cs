using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metod_rasshirenija
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            int c = a.Add(b);
            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
     static class IntEx
    {
        public static int Add(this int v1, int v2)
        {
            return v1 + v2;
        }

    }
}
