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
            // 5 uzduotis

            int k = 5;
            int l = 0;
            Console.WriteLine($"{k} * {l} = {k * l++}");
            Console.WriteLine($"{k} * {l} = {k * l++}");
            Console.WriteLine($"{k} * {l} = {k * l++}");
            Console.WriteLine($"{k} * {l} = {k * l++}");
            Console.WriteLine($"{k} * {l} = {k * l++}");
            Console.WriteLine($"{k} * {l} = {k * l++}");
            Console.WriteLine($"{k} * {l} = {k * l++}");
            Console.WriteLine($"{k} * {l} = {k * l++}");
            Console.WriteLine($"{k} * {l} = {k * l++}");
            Console.WriteLine($"{k} * {l} = {k * l++}");
            Console.WriteLine($"{k} * {l} = {k * l++}");

            // 6 uzduotis

            int dvizenklisSkaicius = 88;
            int desimtys = dvizenklisSkaicius / 10;
            int vienetai = dvizenklisSkaicius % 10;

            Console.WriteLine($"Dvizenklis skaicius: {dvizenklisSkaicius}");
            Console.WriteLine($"Skaitmenu sandauga: {desimtys} * {vienetai}= {desimtys * vienetai}");
        }
    }
}
