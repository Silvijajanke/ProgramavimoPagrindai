using System;


namespace Isvedimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

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

                // uzduotis 12
                // 1. Liepkite įvesti tris skirtingus skaičius. Suraskite, kuris iš šių skaičių yra didžiausias.

                Console.WriteLine("Įveskite tris skaičius, po kiekvienu paspauskite ENTER");
                int numb1 = Convert.ToInt32(Console.ReadLine());
                int numb2 = Convert.ToInt32(Console.ReadLine());
                int numb3 = Convert.ToInt32(Console.ReadLine());

                if (numb3 < numb1 && numb1 > numb2)
                {
                    Console.WriteLine("Pirmas skaičius yra didžiausias");
                }
                else if (numb3 < numb2 && numb2 > numb1)
                {
                    Console.WriteLine("Antras skaičius yra didžiausias");
                }
                else
                {
                    Console.WriteLine("Trečias skaičius yra didžiausias");
                }
                Console.WriteLine("Programos pabaiga");

                // 2. Liepkite įvesti egzamino rezultatą. Atlikite šiuos patikrinimus:
                //ar gautas rezultatas yra[8 - 10];
                //ar gautas rezultatas yra[5 - 8);
                //ar gautas rezultatas yra< 5.

                Console.WriteLine("Įveskite egzamino rezultatą");
                int egzrez = Convert.ToInt32(Console.ReadLine());
                if (egzrez >= 8 && egzrez <= 10)
                {
                    Console.WriteLine("Egzamino rezultatas yra 8, 9 arba 10");
                }
                else if (egzrez >= 5 && egzrez <= 8)
                {
                    Console.WriteLine("Egzamino rezultatas yra 5,6,7 arba 8");
                }
                else
                {
                    Console.WriteLine("Egzamino rezultatas yra mažiau nei 5");
                }
                Console.WriteLine("Programos pabaiga");

                // 3. Liepkite įvesti du skaičius. Patikrinkite (naudojant 4 atskirus if’us):
                //ar pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0;
                //ar antras skaičius yra didesnis už pirmąjį, arba yra lygus 5;
                //ar pirmas skaičius yra didesnis už antrąjį ir yra lygus 20;
                //ar antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100.

                Console.WriteLine("Įveskite du skaičius");
                int pirmsk = Convert.ToInt32(Console.ReadLine());
                int antrska = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (pirmsk > antrska || pirmsk == 0)
                {
                    Console.WriteLine("pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0");
                }
                Console.WriteLine();

                if (antrska > pirmsk || antrska == 5)
                {
                    Console.WriteLine("antras skaičius yra didesnis už pirmąjį, arba yra lygus 5");
                }
                Console.WriteLine();

                if (antrska < pirmsk || pirmsk == 20)
                {
                    Console.WriteLine("pirmas skaičius yra didesnis už antrąjį ir yra lygus 20");
                }
                Console.WriteLine();

                if (antrska > pirmsk && antrska < 100)
                {
                    Console.WriteLine("antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100");
                }
                Console.WriteLine("Programos pabaiga");

                // uzduotis 13
                //Liepkite vartotojui įvesti tris skaičius.Su switch patikrinkite pirmąjį skaičių:
                //ar jis lygus 1: išveskite visų trijų skaičių sumą;
                //ar jis lygus 2: išveskite pirmo ir trečio skaičių skirtumą;
                //ar jis lygus 3: išveskite antro ir trečio skaičių sandaugą.
                Console.WriteLine("Įveskite tris skaičius, po kiekvienu paspauskite ENTER");
                int sk1 = Convert.ToInt32(Console.ReadLine());
                int sk2 = Convert.ToInt32(Console.ReadLine());
                int sk3 = Convert.ToInt32(Console.ReadLine());
                switch (sk1)
                {
                    case 1:
                        Console.WriteLine($"{sk1 + sk2 + sk3}");
                        break;
                    case 2:
                        Console.WriteLine($"{sk1 - sk3}");
                        break;
                    case 3:
                        Console.WriteLine($"{sk3 * sk3}");
                        break;
                }
                Console.WriteLine("Programos pabaiga");

                // 2. uzduotis
                //Liepkite vartotojui įvesti gyvūno rūšį.Su switch patikrinkite:
                //ar įvestas gyvūnas yra šuo;
                //ar įvestas gyvūnas yra katė;
                //ar įvestas gyvūnas yra žiurkėnas.

                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.InputEncoding = System.Text.Encoding.Unicode;

                Console.WriteLine("Įveskite gyvūno rūšį");
                string gyvunas = Console.ReadLine();

                switch (gyvunas)
                {
                    case "šuo":
                        Console.WriteLine("įvestas gyvūnas yra šuo");
                        break;
                    case "katė":
                        Console.WriteLine("įvestas gyvūnas yra katė");
                        break;
                    case "žiurkėnas":
                        Console.WriteLine("įvestas gyvūnas yra žiurkėnas");
                        break;
                }
                Console.WriteLine("Programos pabaiga");

                // uzduotis 14

                // 1. uzduotis
                //Į ekraną išveskite kelis sunumeruotus pasirinkimus 
                // 1 - stacionarus kompiuteris
                //2 - nešiojamas kompiuteris
                //3 - planšetė

                // 2. Liepkite vartotojui įvesti pasirinkimo numerį. 
                // 3. Pagal įvestą numerį išveskite atitinkamą tekstą.
                // Pvz:
                // nešiojamuoju kompiuteriu galite naudotis visur
                // stacionariu kompiuteriu galite naudotis tik namuose arba darbo vietoje
                //planšete galite naudotis visur
                //Neradus tinkamo varianto išvesti, kad tokio pasirinkimo nėra.

                Console.WriteLine("Pasirinkimai : ");
                Console.WriteLine("1 - stacionarus kompiuteris");
                Console.WriteLine("2 - nešiojamas kompiuteris");
                Console.WriteLine("3 - planšetė");
                Console.WriteLine("Išsirinkite vieną įrenginį ir parašykite jo numerį");
                int ireng = Convert.ToInt32(Console.ReadLine());
                switch (ireng)
                {
                    case 1:
                        Console.WriteLine("stacionariu kompiuteriu galite naudotis tik namuose arba darbo vietoje");
                        break;
                    case 2:
                        Console.WriteLine("nešiojamuoju kompiuteriu galite naudotis visur");
                        break;
                    case 3:
                        Console.WriteLine("planšete galite naudotis visur");
                        break;
                    default:
                        Console.WriteLine("tokio pasirinkimo nėra");
                        break;
                }

                Console.WriteLine();
                // uzduotis 15
                // 1. Parašyti for, kuris išvestų kiekvieną skaičių pradedant nuo 0 ir baigiant 10.
                // Kiekvieną skaičių išvesti skirtingoje eilutėje.

                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
                Console.WriteLine("Programos pabaiga");
                Console.WriteLine();

                // 2. Parašyti for, kuris išvestų kas antrą skaičių pradedant 0 ir baigiant 15.
                //Kiekvieną skaičių išvesti toje pačioje eilutėje, po kiekvieno skaičiaus dedant
                //tarpą.

                for (int i = 0; i <= 15; ++i)
                {
                    Console.Write(i++ + " ");
                }

                Console.WriteLine();
                Console.WriteLine("Programos pabaiga");
                Console.WriteLine();

                // 3. Parašyti for, kuris išvestų kas trečią skaičių, pradedant 1 ir baigiant 20.
                //Kiekvieną skaičių išvesti toje pačioje eilutėje,
                //tačiau parašant skaičių laužtiniuose skliaustuose.Pvz.: [1][4][7]


                for (int i = 1; i <= 20; i += 2)
                {

                    Console.Write("[" + i + "]" + " ");
                }

                Console.WriteLine();
                Console.WriteLine("Programos pabaiga");
                Console.WriteLine();
            }
        }
    }
}
