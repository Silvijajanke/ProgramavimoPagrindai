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
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Įveskite bet kokį sveikąjį skaičių");
            int sveikasis = Console.ReadLine();
            int l = 0;
            Console.WriteLine($"{sveikasis} * {l} = {sveikasis * l++}");
            Console.WriteLine($"{sveikasis} * {l} = {sveikasis * l++}");
            Console.WriteLine($"{sveikasis} * {l} = {sveikasis * l++}");
            Console.WriteLine($"{sveikasis} * {l} = {sveikasis * l++}");
            Console.WriteLine($"{sveikasis} * {l} = {sveikasis * l++}");
            Console.WriteLine($"{sveikasis} * {l} = {sveikasis * l++}");
            Console.WriteLine($"{sveikasis} * {l} = {sveikasis * l++}");
            Console.WriteLine($"{sveikasis} * {l} = {sveikasis * l++}");
            Console.WriteLine($"{sveikasis} * {l} = {sveikasis * l++}");
            Console.WriteLine($"{sveikasis} * {l} = {sveikasis * l++}");
            Console.WriteLine($"{sveikasis} * {l} = {sveikasis * l++}");
        }
    }
}
