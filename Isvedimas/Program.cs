using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isvedimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 uzduotis
            int a = 108;
            int b = 88;
            int c = a + b;
            int d = a - b;
            int e = a * b;
            double f = (double)a / b;
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            //2 uzduotis
            int h = 8;
            int j = (h * h);
            Console.WriteLine(Math.Pow(j, 3));

            //3 uzduotis
            int u = 108;
            int t = 88;
            int r = 10;
            Console.WriteLine(u * t * r);
        }
    }
}
