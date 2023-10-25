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


            // Uzduotis 8


            //  1. Liepkite vartotojui įvesti bet kokį sveikąjį skaičių.
            //  Išveskite šio skaičiaus daugybos lentelę nuo 1 iki 5.

            Console.WriteLine("Įveskite bet kokį sveikąjį skaičių");
            int sveikasis = Convert.ToInt32(Console.ReadLine());
            int l = 1;
            Console.WriteLine($"{sveikasis} * {l} = {sveikasis * l++}");
            Console.WriteLine($"{sveikasis} * {l} = {sveikasis * l++}");
            Console.WriteLine($"{sveikasis} * {l} = {sveikasis * l++}");
            Console.WriteLine($"{sveikasis} * {l} = {sveikasis * l++}");
            Console.WriteLine($"{sveikasis} * {l} = {sveikasis * l++}");

            // 2. Liepkite vartotojui įvesti tris skaičius. Į ekraną išveskite šiuos skaičius ir jų vidurkį.
            // Pvz.: Įvestų skaičių 4, 5, 8 vidurkis: 5,7.

            Console.WriteLine("Įveskite bet kokius tris skaičius ir paspauskite ENTER po kiekvienu iš jų");
            int pirmas = Convert.ToInt32(Console.ReadLine());
            int antras = Convert.ToInt32(Console.ReadLine());
            int trecias = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įvestų skaičių vidurkis:");
            Console.WriteLine($"({pirmas} + {antras} + {trecias}) / 3 = " + $"{(pirmas + antras + trecias) / 3 }");

            // 3. Liepkite įvesti tris skaičius.
            // Išveskite įvestus skaičius, jų kvadratus,
            // juos pakeltus trečiuoju laipsniu, taip pat tuos skaičius, padalintus iš dviejų.

            Console.WriteLine("Įveskite bet kokius tris skaičius ir paspauskite ENTER po kiekvienu iš jų");
            int skaic1 = Convert.ToInt32(Console.ReadLine());
            int skaic2 = Convert.ToInt32(Console.ReadLine());
            int skaic3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įvesti skaičiai yra:" + $"{skaic1}, {skaic2}, {skaic3}");

            Console.WriteLine("Įvesto skaičiaus kvadratas yra: ");
            Console.WriteLine($"{skaic1 * skaic1}");
            Console.WriteLine($"{skaic2 * skaic2}");
            Console.WriteLine($"{skaic3 * skaic3}");

            Console.WriteLine("Įvestas skaičius pakeltas trečiuoju laipsniu: ");
            Console.WriteLine($"{skaic1 ^ 3 }");
            Console.WriteLine($"{skaic2 ^ 3 }");
            Console.WriteLine($"{skaic3 ^ 3 }");

            Console.WriteLine("Įvestas skaičius padalintas iš 2 : ");
            Console.WriteLine($"{(double)skaic1 / 2 }");
            Console.WriteLine($"{(double)skaic2 / 2 }");
            Console.WriteLine($"{(double)skaic3 / 2 }");

        }
    }
}
