using System;


namespace Isvedimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string marke = "Fiat";
            string modelis = "Fiat500";
            int metai = 2008;
            int rida = 151000;
            Console.WriteLine($"Automobilio {marke} {modelis} ({metai} m.) rida - {rida}");
        }
    }
}
