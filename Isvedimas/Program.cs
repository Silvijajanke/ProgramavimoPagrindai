using System;


namespace Isvedimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // 1
            Console.WriteLine("Labas, Silvija");

            //2
            int amzius = 34;
            Console.WriteLine("Įvestas amžius {0}", amzius);

            //3
            int skaicius = 25;
            Console.WriteLine("Skaičius {0}{0}{0}{0}{0}", skaicius);

            //4
            int a = 25;
            Console.WriteLine($"Skaičius {a} {a} {a} {a} {a}");
        }
    }
}
