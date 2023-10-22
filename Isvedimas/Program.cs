using System;


namespace Isvedimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //uzduotis 1 
            Console.WriteLine("Įveskite savo vardą:");
            string vardas = Console.ReadLine();
            Console.WriteLine("Įveskite savo amžių:");
            int amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Jūsų vardas {vardas}, o amžius {amzius}");


            //uzduotis 2

            Console.WriteLine("Įveskite bet kokį simbolį:");
            char simbolis = Convert.ToChar(Console.ReadLine());
            char o = ' ';
            Console.WriteLine($"{simbolis} {simbolis} {simbolis}");
            Console.WriteLine($"{simbolis} {o} {simbolis} ");
            Console.WriteLine($"{simbolis} {simbolis} {simbolis}");

            //uzduotis 3 

            Console.WriteLine("Įveskite bet kokį skaičių:");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            char o = ' ';
            Console.WriteLine($"{skaicius} {skaicius} {skaicius} {skaicius}");
            Console.WriteLine($"{skaicius} {o} {skaicius} ");
            Console.WriteLine($"{skaicius} {o} {skaicius} ");
            Console.WriteLine($"{skaicius} {o} {skaicius} ");
            Console.WriteLine($"{skaicius} {skaicius} {skaicius} {skaicius}");
        }
    }
}
