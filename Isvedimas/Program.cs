using System;


namespace Isvedimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // uzduotis 1

            // Liepkite vartotojui įvesti savo vardą ir amžių.
            //Į ekraną išveskite: “Jūsų vardas {vardas}, o amžius {amžius}.

            Console.WriteLine("Įveskite savo vardą:");
            string vardas = Console.ReadLine();
            Console.WriteLine("Įveskite savo amžių:");
            int amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Jūsų vardas {vardas}, o amžius {amzius}");


            //uzduotis 2
            //Liepkite vartotojui įvesti bet kokį simbolį.
            //Atspausdinkite 3x3 kvadratą iš to simbolio.


            Console.WriteLine("Įveskite bet kokį simbolį:");
            char simbolis = Convert.ToChar(Console.ReadLine());
            char o = ' ';
            Console.WriteLine($"{simbolis} {simbolis} {simbolis}");
            Console.WriteLine($"{simbolis} {o} {simbolis} ");
            Console.WriteLine($"{simbolis} {simbolis} {simbolis}");

            //uzduotis 3 
            //Liepkite vartotojui įvesti bet kokį skaičių. Išveskite į ekraną šio skaičiaus kvadratą.

            Console.WriteLine("Įveskite bet kokį skaičių:");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            char p = ' ';
            Console.WriteLine($"{skaicius} {skaicius} {skaicius} {skaicius}");
            Console.WriteLine($"{skaicius} {p} {p} {skaicius}");
            Console.WriteLine($"{skaicius} {p} {p} {skaicius}");
            Console.WriteLine($"{skaicius} {skaicius} {skaicius} {skaicius}");

            // uzduotis 4
            
            //Liepkite vartotojui įvesti tris skaičius.
            //Išveskite visų šių skaičių sumą, skirtumą, sandaugą ir dalmenį, 
            //nurodant atliekamus veiksmus ir šių skaičių reikšmes ekrane.

            Console.WriteLine("Įveskite bet kokį skaičių:");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite dar vieną bet kokį skaičių:");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite paskutinį bet kokį skaičių:");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Visų skaičių suma: ");
            Console.WriteLine($"{skaicius1} + {skaicius2} + {skaicius3} = " + $"{skaicius1 + skaicius2 + skaicius3}");
        }
    }
}
