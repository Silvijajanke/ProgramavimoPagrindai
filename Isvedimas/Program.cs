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

            // uzduotis 1

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

            // uzduotis 2 

            Console.WriteLine("Įveskite bet kokius tris skaičius");
            int pirmas = Console.ReadLine();
            int antras = Console.ReadLine();
            int trecias = Console.ReadLine();
            Console.WriteLine("Įvestų skaičių vidurkis:");
            Console.WriteLine($"({pirmas} * {antras} * {trecias}) / 3 = ${(pirmas*antras*trecias)/3}");


        }
    }
}
