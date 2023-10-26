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
            Console.WriteLine($"({pirmas} + {antras} + {trecias}) / 3 = " + $"{(pirmas + antras + trecias) / 3}");

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
            Console.WriteLine($"{skaic1 ^ 3}");
            Console.WriteLine($"{skaic2 ^ 3}");
            Console.WriteLine($"{skaic3 ^ 3}");

            Console.WriteLine("Įvestas skaičius padalintas iš 2 : ");
            Console.WriteLine($"{(double)skaic1 / 2}");
            Console.WriteLine($"{(double)skaic2 / 2}");
            Console.WriteLine($"{(double)skaic3 / 2}");


            // uzduotis 9

            // 1. Liepkite vartotojui įvesti savo amžių.
            // Jei amžius yra 18 arba daugiau, tuomet į ekraną išveskite, kad “jūs galite balsuoti”.

            Console.WriteLine("Įveskite savo amžių");
            int balsavimoAmzius = Convert.ToInt32(Console.ReadLine());
            if (balsavimoAmzius >= 18)
            {
                Console.WriteLine("Jūs galite balsuoti");
            }
            Console.WriteLine("Kita užduotis");


            // 2. Liepkite vartotojui įvesti bet kokį skaičių. Parašykite šias atskiras if sąlygas:
            //Patikrinti, ar skaičius neigiamas, jei taip -aprėkti vartotoją:)
            //Patikrinti, ar skaičius teigiamas, jei taip -pasveikinti vartotoją;
            //Patikrinti, ar skaičius lyginis, jei taip -išvesti “taip, skaičius yra lyginis”;
            //Patikrinti, ar skaičius dalinasi iš 4, jei taip -išvesti “taip, dalinasi iš 4”;
            //Patikrinti, ar skaičius yra didesnis nei 10, jei taip -išvesti “taip, skaičius yra didesnis už 10”

            Console.Write("Patikrinimas ar skaičius yra neigiamas.");
            Console.WriteLine("Įveskite bet kokį skaičių");
            int betKokSkaic = Convert.ToInt32(Console.ReadLine());
            if (betKokSkaic < 0)
            {
                Console.WriteLine("Skaičius yra neigiamas!!!!!");
            }
            Console.WriteLine();
            Console.WriteLine("Kita užduotis");
            Console.Write("Patikrinimas ar skaičius yra teigiamas.");
            Console.WriteLine("Įveskite bet kokį skaičių");
            int betKokSkaic1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (betKokSkaic1 > 0)
            {
                Console.WriteLine("Sveikiname, skaičius yra teigiamas");
            }
            Console.WriteLine();
            Console.WriteLine("Kita užduotis");
            Console.Write("Patikrinimas ar skaičius yra lyginis.");
            Console.WriteLine("Įveskite bet kokį skaičių");
            int betKokSkaic2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (betKokSkaic2 % 2 == 0)
            {
                Console.WriteLine("Taip,skaičius yra lyginis");
            }
            Console.WriteLine("Kita užduotis");
            Console.Write("Patikrinimas ar skaičius dalinasi iš 4.");
            Console.WriteLine("Įveskite bet kokį skaičių");
            int betKokSkaic3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if ((betKokSkaic3 % 4) == 0)
            {
                Console.WriteLine("Taip,dalinasi iš 4");
            }
            Console.WriteLine();
            Console.WriteLine("Kita užduotis");
            Console.Write("Patikrinimas ar skaičius yra didesnis už 10.");
            Console.WriteLine("Įveskite bet kokį skaičių");
            int betKokSkaic4 = Convert.ToInt32(Console.ReadLine());
            if (betKokSkaic4 > 10)
            {
                Console.WriteLine("Taip, skaičius yra didesnis už 10");
            }
            Console.WriteLine();


            // 3. Liepkite vartotojui įvesti du savo pažymius,
            //raskite šių pažymių vidurkį, patikrinkite, ar vidurkis yra lygus arba didesnis už 5,
            //jei taip, išveskite “Valio!!!”

            Console.WriteLine("Įveskite pirmąjį pažymį paspauskite ENTER ir tada įveskite antrąjį");
            int pazimys1 = Convert.ToInt32(Console.ReadLine());
            int pazimys2 = Convert.ToInt32(Console.ReadLine());
            double vidurkis = (pazimys1 + pazimys2) / 2;
            Console.WriteLine("Pažymių vidurkis : " + vidurkis);
            if (vidurkis >= 5)
            {
                Console.WriteLine("Valio!");
            }
            Console.WriteLine();

            //Uzduotis 10

            //1. Liepkite įvesti skaičių.
            //Jei skaičius lyginis, tuomet išveskite šį skaičių bei jo penktą laipsnį.
            //Jei skaičius nesidalina iš 4, tuomet liepkite įvesti antrąjį skaičių.
            //Išveskite abiejų skaičių sumą ir sandaugą.

            Console.WriteLine("Įveskite skaičių");
            int ivestaskaicius = Convert.ToInt32(Console.ReadLine());
            if (ivestaskaicius % 2 == 0)
            {
                Console.WriteLine("Įvestas skaičius :" + ivestaskaicius);
                Console.WriteLine($"{ivestaskaicius ^ 5}");
            }
            if (ivestaskaicius % 4 != 0)
            {
                Console.WriteLine("Įveskite antrąjį skaičių");
                int antrsk = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Įvestų skaičių suma : ");
                Console.WriteLine($"{ivestaskaicius + antrsk}");
                Console.WriteLine("Įvestų skaičių sandauga : ");
                Console.WriteLine($"{ivestaskaicius * antrsk}");

                // uzduotis 11
                // 1. Liepkite vartotojui įvesti tris skaičius, parašyti šią patikrinimo sąlygą, naudojant else if dalis:
                //ar pirmas skaičius didesnis už antrą;
                //ar antras skaičius didesnis už trečią;
                //ar trečias skaičius didesnis už pirmą;
                //ar pirmi du skaičiai lygūs;

                Console.WriteLine("Įveskite tris skaičius, po kiekvienu paspauskite ENTER");
                int number1 = Convert.ToInt32(Console.ReadLine());
                int number2 = Convert.ToInt32((Console.ReadLine()));
                int number3 = Convert.ToInt32((Console.ReadLine()));
                if (number1 > number2)
                {
                    Console.WriteLine("Pirmas skaičius didesnis už antrą");
                }
                else if (number2 > number3)
                {
                    Console.WriteLine("Antras skaičius didesnis už trečią");
                }
                else if (number3 > number1)
                {
                    Console.WriteLine("Trečias skaičius didesnis už pirmą");
                }
                else if (number1 == number2)
                {
                    Console.WriteLine("Pirmi du skaičiai lygūs");
                }
                Console.WriteLine("Programos pabaiga");

                // 2. Liepkite vartotojui įvesti šios dienos oro temperatūrą, atlikite šiuos patikrinimus:
                //ar temperatūra< 0 - išvesti “žiauriai šalta”;
                //ar temperatūra< 10 - išvesti “labai šalta”;
                //ar temperatūra< 20 - išvesti “šalta”;
                //ar temperatūra< 30 - išvesti “normali temperatūra”;
                //ar temperatūra< 40 - išvesti “karšta”;
                //ar temperatūra >= 40 - išvesti “visiškai degina”;

                Console.WriteLine("Įveskite šios dienos temperatūrą");
                int temp = Convert.ToInt32(Console.ReadLine());

                if (temp < 0)
                {
                    Console.WriteLine("žiauriai šalta");
                }
                else if (temp < 10)
                {
                    Console.WriteLine("labai šalta");
                }
                else if (temp < 20)
                {
                    Console.WriteLine("šalta");
                }
                else if (temp < 30)
                {
                    Console.WriteLine("normali temperatūra");
                }
                else if (temp < 40)
                {
                    Console.WriteLine("karšta");
                }
                else if (temp >= 40)
                {
                    Console.WriteLine("visiškai degina");
                }
                
                Console.WriteLine("Programos pabaiga ");
            }

        }
    }
}
