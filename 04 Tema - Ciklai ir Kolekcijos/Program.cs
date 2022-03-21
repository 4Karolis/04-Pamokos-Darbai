using System;
using System.Collections.Generic;

namespace _04_Tema___Ciklai_ir_Kolekcijos
{
    class Program
    {
        static void Main(string[] args)
        {
            ////------------------------------------------------- PAPRASTAS CIKLAS -------------------------------------------------
            ///
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Sukasi ciklas. Siuo metu yra: {i}");
            //}
            ////----------------------------------------------- MAZEJANTIS CIKLAS --------------------------------------------------
            ///
            //for (int i = 10; i >=0; i--)
            //{
            //    Console.WriteLine($"Ciklas mazeja. Siuo metu yra: {i}");
            //}
            ////--------------------------------------------- CIKLAS su ZINGSNIU ---------------------------------------------------
            //
            //for (int i = 0; i < 10; i +=2) // kad kas antra skaiciuotu rasom "+=2"
            //{
            //    Console.WriteLine($"Sukasi ciklas. Siuo metu yra {i}");
            //}

            ////------------------------------------ INTERACIJOS per SIMBOLIU DIAPOZONA -------------------------------------------

            //for (char i = 'a'; i <= 'z'; i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////----------------------------------------------- ITERACIJA per STRINGA ----------------------------------------------

            //string name = "Petriukas";
            //int lenght = name.Length;
            //for (int i = 0; i < name.Length; i++) // suks kiekviena raide kol pasibaigs vardo ilgis
            //{
            //    char current = name[i];
            //    Console.WriteLine(current);
            //}

            ////------------------------------------------------- AMZINAS CIKLAS ---------------------------------------------------

            //while (true)
            //{
            //    Console.WriteLine("AMZINAI");
            //}

            //for (; ; )
            //{
            //    Console.WriteLine("AMZINAI");
            //}

            ////----------------------------------------------- PABEGIMAS is CIKLO -------------------------------------------------

            //string name = "Petriukas";
            //int lenght = name.Length;

            //for (int i = 0; i < name.Length; i++)
            //{
            //    char current = name[i];
            //    if (current == 'u')
            //    {
            //        break;
            //    }
            //    Console.WriteLine(current);
            //}

            ////-------------------------------------------- CIKLO PRATESIMAS - CONTINUE -------------------------------------------

            //string name = "Petriukas";
            //int lenght = name.Length;

            //for (int i = 0; i < name.Length; i++)
            //{
            //    char current = name[i];
            //    if (current == 'u')
            //    {
            //        continue; // neiseis, o pasiekes tikslas prades vel salyga nuo pradziu (iseina is IF ciklo ir tesia FOR cikla)
            //    }
            //    Console.WriteLine(current);
            //}

            ////---------------------------------------------------------------------------------------------------------------------

            //string name = "Petriukas";
            //int lenght = name.Length;

            //foreach (char simbolis in name)
            //{
            //    var index = name.IndexOf(simbolis);
            //    Console.WriteLine(simbolis);
            //}

            ////---------------------------------------------------- 1 UZDUOTIS ------------------------------------------------------
            ////------------------------------------------- Nemeluosiu, pagooglinau --------------------------------------------------

            //Console.WriteLine("iveskite pirma skaiciu: ");
            //int pirmas = int.Parse(Console.ReadLine());
            //Console.WriteLine("iveskite antra skaiciu: ");
            //int antras = int.Parse(Console.ReadLine());

            //int suma = 0;

            //for (int x = pirmas; x <= antras; x++)
            //{
            //    suma += x;
            //}
            ////Console.WriteLine("\nSuma tarp visu jusu ivestu skaicu (imtinai) yra: {0}", suma);
            //Console.WriteLine($"\nVisu skaiciu tarp {pirmas} ir {antras} suma (imtinai) yra: {suma}");//SAME


            ////int pirmas = 1;
            //Console.WriteLine("iveskite antra skaiciu: ");
            //int antras = int.Parse(Console.ReadLine());

            //int suma = 0;

            //for (int i = 1; i <= antras; i++)
            //{
            //    suma += i;
            //}
            ////Console.WriteLine("\nSuma tarp visu jusu ivestu skaicu (imtinai) yra: {0}", suma);
            //Console.WriteLine($"\nVisu skaiciu tarp 1 ir {antras} suma (imtinai) yra: {suma}");//SAME


            ////---------------------------------------------------- 2 UZDUOTIS ------------------------------------------------------

            //Console.WriteLine("Iveskite bet koki skaiciu: ");
            //int skaicius = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= skaicius; i += 2)
            //{
            //    Console.WriteLine($"Nuo 0 iki jusu ivesto skaiciaus lyginiai skaiciai yra: {i}");
            //}

            ////--------------------------------------------------- 3 UZDUOTIS -------------------------------------------------------

            //Console.WriteLine("Iveskite bet koki sakini:");
            //string sakinys = Console.ReadLine();

            //for (int i = sakinys.Length - 1; i >= 0; i--) // Loopina string'a nuo ivesties gali iki pradzios
            //{
            //   //Console.WriteLine("Atvirkstinis jusu ivestas sakinys: {0}", sakinys[i]);
            //    Console.WriteLine($"Atvirkstinis jusu ivestas sakinys: {sakinys[i]}");
            //}

            ////--------------------------------------------------- 4 UZDUOTIS ------------------------------------------------------
            ////------------------------------------------------- Kazka sugadinau :D ------------------------------------------------

            //Console.WriteLine("Iveskite pirma skaiciu: ");
            //double skaicius1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Iveskite antra skaiciu: ");
            //double skaicius2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Pasirinkite koki veiksma norite atlikti: 1 - Sudetis; 2 - Atimtis; 3 - Daugyba; 4 - Dalyba;");
            //int pasirinkimas = int.Parse(Console.ReadLine());

            //double suma = skaicius1 + skaicius2;
            //double atimtis = skaicius1 - skaicius2;
            //double daugyba = skaicius1 * skaicius2;
            //double dalyba = skaicius1 / skaicius2;

            //switch (pasirinkimas)
            //{
            //    case 1:
            //        Console.WriteLine($"{skaicius1} + {skaicius2} = {suma}");
            //        break;
            //    case 2:
            //        Console.WriteLine($"{skaicius1} - {skaicius2} = {atimtis}");
            //        break;
            //    case 3:
            //        Console.WriteLine($"{skaicius1} * {skaicius2} = {daugyba}");
            //        break;
            //    case 4:
            //        Console.WriteLine($"{skaicius1} / {skaicius2} = {dalyba}");
            //        break; ;
            //}

            //Console.WriteLine("Noredami testi spauskite 'T', noredami iseiti is programos spauskite 'ENTER'");
            //string testi = Console.ReadLine();
            //bool bicasNoriTesti = testi == "t";

            //while (bicasNoriTesti)
            //{
            //    Console.WriteLine("Iveskite pirma skaiciu: ");
            //    double skaicius3 = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Iveskite antra skaiciu: ");
            //    double skaicius4 = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Pasirinkite koki veiksma norite atlikti: 1 - Sudetis; 2 - Atimtis; 3 - Daugyba; 4 - Dalyba;");
            //    int pasirinkimas2 = int.Parse(Console.ReadLine());

            //    double suma2 = skaicius3 + skaicius4;
            //    double atimtis2 = skaicius3 - skaicius4;
            //    double daugyba2 = skaicius3 * skaicius4;
            //    double dalyba2 = skaicius3 / skaicius4;

            //    switch (pasirinkimas2)
            //    {
            //        case 1:
            //            Console.WriteLine($"{skaicius3} + {skaicius4} = {suma}");
            //            break;
            //        case 2:
            //            Console.WriteLine($"{skaicius3} - {skaicius4} = {atimtis}");
            //            break;
            //        case 3:
            //            Console.WriteLine($"{skaicius3} * {skaicius4} = {daugyba}");
            //            break;
            //        case 4:
            //            Console.WriteLine($"{skaicius3} / {skaicius4} = {dalyba}");
            //            break; ;
            //    }
            //    Console.WriteLine("Noredami testi spauskite 'T', noredami iseiti is programos spauskite 'ENTER'");
            //    string testi2 = Console.ReadLine();
            //    bool bicasNoriTesti2 = testi2 == "t";
            //    Console.WriteLine("Aciu kad naudojates musu paslaugomis. Iki kito karto!");
            //    Console.ReadLine();

            ////-------------------------------------------------- 4 UZDUOTIS V.2 -----------------------------------------------------

            //do
            //{
            //    Console.WriteLine("Iveskite pirma skaiciu: ");
            //    double skaicius1 = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Iveskite antra skaiciu: ");
            //    double skaicius2 = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Pasirinkite koki veiksma norite atlikti: 1 - Sudetis; 2 - Atimtis; 3 - Daugyba; 4 - Dalyba;");
            //    int pasirinkimas = int.Parse(Console.ReadLine());

            //    double suma = skaicius1 + skaicius2;
            //    double atimtis = skaicius1 - skaicius2;
            //    double daugyba = skaicius1 * skaicius2;
            //    double dalyba = skaicius1 / skaicius2;

            //    switch (pasirinkimas)
            //    {
            //        case 1:
            //            Console.WriteLine($"{skaicius1} + {skaicius2} = {suma}");
            //            break;
            //        case 2:
            //            Console.WriteLine($"{skaicius1} - {skaicius2} = {atimtis}");
            //            break;
            //        case 3:
            //            Console.WriteLine($"{skaicius1} * {skaicius2} = {daugyba}");
            //            break;
            //        case 4:
            //            Console.WriteLine($"{skaicius1} / {skaicius2} = {dalyba}");
            //            break;
            //    }
            //    Console.WriteLine("Noredami testi spauskite 'T', noredami iseiti is programos spauskite 'ENTER'");
            //    string testi = Console.ReadLine();
            //    bool bicasNoriTesti = testi == "t";
            //} while (true);

            //Console.WriteLine("Aciu kad naudojates musu paslaugomis. Iki kito karto!");
            //Console.ReadLine();

            ////-------------------------------------------------- 4 UZDUOTIS V.3 -----------------------------------------------------

            //for (; ; )
            //{
            //    Console.WriteLine("Iveskite pirma skaiciu: ");
            //    double skaicius1 = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Iveskite antra skaiciu: ");
            //    double skaicius2 = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Pasirinkite koki veiksma norite atlikti: \n1 - Sudetis; 2 - Atimtis; 3 - Daugyba; 4 - Dalyba;");
            //    int pasirinkimas = int.Parse(Console.ReadLine());

            //    double suma = skaicius1 + skaicius2;
            //    double atimtis = skaicius1 - skaicius2;
            //    double daugyba = skaicius1 * skaicius2;
            //    double dalyba = skaicius1 / skaicius2;

            //    switch (pasirinkimas)
            //    {
            //        case 1:
            //            Console.WriteLine($"{skaicius1} + {skaicius2} = {suma}");
            //            break;
            //        case 2:
            //            Console.WriteLine($"{skaicius1} - {skaicius2} = {atimtis}");
            //            break;
            //        case 3:
            //            Console.WriteLine($"{skaicius1} * {skaicius2} = {daugyba}");
            //            break;
            //        case 4:
            //            Console.WriteLine($"{skaicius1} / {skaicius2} = {dalyba}");
            //            break;
            //    }
            //    Console.WriteLine("Noredami testi spauskite 't', noredami iseiti is programos spauskite 'ENTER'");
            //    string testi = Console.ReadLine();
            //    if (testi != "t")
            //    {
            //        Console.WriteLine("Aciu kad naudojates musu paslaugomis. Iki kito karto!");
            //        //Console.ReadLine();
            //        break;
            //    }

            //}

            //--------------------------------------- 4 UZDUOTI V.4 -------------------------------------------

            //for (; ; )
            //{
            //    double num1, num2, pasirinkimas;
            //    while (true)
            //    {
            //        Console.WriteLine("Iveskite pirma skaiciu: ");
            //        if (double.TryParse(Console.ReadLine(), out num1))
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Neteisingai ivestas skaicius. Bandykite dar karta.");
            //        }
            //    }
            //    while (true)
            //    {
            //        Console.WriteLine("Iveskite antra skaiciu: ");
            //        if (double.TryParse(Console.ReadLine(), out num2))
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Neteisingai ivestas skaicius. Bandykite dar karta.");
            //        }
            //    }
            //    while (true)
            //    {
            //        Console.WriteLine("Pasirinkite koki veiksma norite atlikti: \n1 - Sudetis; 2 - Atimtis; 3 - Daugyba; 4 - Dalyba;");
            //        if (double.TryParse(Console.ReadLine(), out pasirinkimas))
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Neteisingai ivestas skaicius. Bandykite dar karta.");
            //        }
            //    }

            //    switch (pasirinkimas)
            //    {
            //        case 1:
            //            double suma = num1 + num2;
            //            Console.WriteLine($"{num1} + {num2} = {suma}");
            //            break;
            //        case 2:
            //            double atimtis = num1 - num2;

            //            Console.WriteLine($"{num1} - {num2} = {atimtis}");
            //            break;
            //        case 3:
            //            double daugyba = num1 * num2;

            //            Console.WriteLine($"{num1} * {num2} = {daugyba}");
            //            break;
            //        case 4:
            //            double dalyba = num1 / num2;

            //            Console.WriteLine($"{num1} / {num2} = {dalyba}");
            //            break;
            //        default:
            //            Console.WriteLine("Ivestas neteisingas pasirinkimas. Bandykite dar karta");
            //            break;
            //    }

            //    Console.WriteLine("Noredami testi spauskite 't', noredami iseiti is programos spauskite 'ENTER' arba bet kuri kita mygtuka");
            //    string testi = Console.ReadLine();
            //    testi.Equals((testi), StringComparison.OrdinalIgnoreCase); Console.ReadLine();
            //    bool valid = testi == "t" || testi == "T";
            //    if (!valid)
            //    {
            //        Console.WriteLine("Aciu kad naudojates musu paslaugomis. Iki kito karto!");
            //        break;
            //    }

            //}
            //-------------------------------------------------------------------------------------------------------------------------------

            #region KOLEKCIJOS TEORIJA

            //string[] savaitesDienos =
            //{
            //    "Pirmadienis",
            //    "Antradienis",
            //    "Treciadienis",
            //    "Ketvirtadienis",
            //    "Penbnktadienis",
            //    "Sestadienis",
            //    "Sekmadienis",
            //};
            //for (int i = 0; i < savaitesDienos.Length; i++)
            //{
            //    Console.WriteLine(savaitesDienos[i]);
            //}

            //int[] integers = { 1, 5, 6 };

            //string pirmadienis = savaitesDienos[0];
            //Console.WriteLine("Kuria savaites diena parodyti?");
            //Console.WriteLine("Pirmadienis  - 1 ir t.t.");

            //int index = int.Parse(Console.ReadLine());
            //string selectedDay = savaitesDienos[index - 1];

            //Console.WriteLine($"Buvo pasirinkta savaites diena:{selectedDay} ");

            //// Elemento keitimas masyve 
            //Console.WriteLine("Pries:");

            //foreach (var diena in savaitesDienos)
            //{
            //    Console.WriteLine(diena);
            //}

            //savaitesDienos[2] = "TRECIADIENIS";

            //Console.WriteLine("Po: ");
            //foreach(var diena in savaitesDienos)
            //{
            //    Console.WriteLine(diena);
            //}

            //// Masyvo uzpildymas random skaiciais
            //int[] skaiciai  = new int[10];
            //string[] t = new string[10];

            //Random random = new Random();

            //for (int i = 0; i < skaiciai.Length; i++)
            //{
            //    skaiciai[i] = random.Next(1, 100);// generuo 10 random skaiciu, verte nuo 1 iki 100
            //}
            //foreach (var skaicius in skaiciai)
            //{
            //    Console.WriteLine(skaicius);
            //}



            ////MSYVO DYZDIO KEITIMAS

            //char[] zodis = new char[6];
            //zodis[0] = 'K';
            //zodis[1] = 'u';
            //zodis[2] = 'r';
            //zodis[3] = 's';
            //zodis[4] = 'a';
            //zodis[5] = 's';

            //foreach (var raide in zodis)
            //{
            //    Console.WriteLine(raide);
            //}

            //Array.Resize(ref zodis, 8);

            //zodis[6] = 'C';
            //zodis[7] = '#';

            //foreach (var raide in zodis)
            //{
            //    Console.WriteLine(raide);
            //}
            #endregion

            #region UZDUOYS 
            //------------------------------------------------ 1 UZDUOTIS ----------------------------------------------------------


            //Console.WriteLine("Iveskite pirma skaiciu: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Iveskite antra skaiciu: ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Iveskite trecia skaiciu: ");
            //int num3 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Iveskite ketvirta skaiciu: ");
            //int num4 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Iveskite penkta skaiciu: ");
            //int num5 = int.Parse(Console.ReadLine());


            //int[] skaiciai = new int[5];
            //skaiciai[0] = num1;
            //skaiciai[1] = num2;
            //skaiciai[2] = num3;
            //skaiciai[3] = num4;
            //skaiciai[4] = num5;

            //int[] temp = skaiciai;

            //Console.WriteLine("Jusu ivesti skaiciai yra: ");
            //foreach (var skaicius in skaiciai)
            //{
            //    Console.WriteLine(skaicius);
            //}

            //Array.Reverse(temp);
            //Console.WriteLine("Jusu ivesti skaiciai atvirkstine tvarka: ");
            //foreach (var skaicius2 in temp)
            //{
            //    Console.WriteLine(skaicius2);
            //}


            //////-------------------------------------------------- 2 UZDUOTIS ----------------------------------------------------

            //int[] arr = skaiciai;
            //int suma = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    suma += arr[i];
            //}
            //Console.WriteLine($"Jusu ivestu skaiciu suma: {suma}");

            ////--------------------------------------------------- 3 UZDUOTIS ----------------------------------------------------

            //Console.WriteLine("Iveskite pirma skaiciu: ");
            //int input1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Iveskite antra skaiciu: ");
            //int input2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Iveskite trecia skaiciu: ");
            //int input3 = int.Parse(Console.ReadLine());

            //int[] inputai = new int[3] {input1,input2,input3};
            //Console.WriteLine($"Siuo metu masyve esantys skaiciai: ");

            //foreach (var inputas in inputai)
            //{
            //    Console.WriteLine(inputas);
            //}

            //Console.WriteLine("Iveskite ketvirta skaiciu: ");
            //int input4 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Iveskite penkta skaiciu: ");
            //int input5 = int.Parse(Console.ReadLine());

            //Array.Resize(ref inputai, 5);
            //inputai[3] = input4;
            //inputai[4] = input5;

            //Console.WriteLine("Dabar masyve esantys skaiciai: ");
            //foreach (var inputas in inputai)
            //{
            //    Console.WriteLine(inputas);
            //}

            //------------------------------------------------------ 4 UZDUOTIS ---------------------------------------------------

            //int[] skaiciai = new int[10];

            //Random random = new Random();

            //for (int i = 0; i < skaiciai.Length; i++)
            //{
            //    skaiciai[i] = random.Next(1, 100);// generuo 10 random skaiciu, verte nuo 1 iki 100
            //}

            //Console.WriteLine("Masyve esantys atsitiktiniai skaiciai: ");
            //foreach (var skaicius in skaiciai)
            //{
            //    Console.WriteLine(skaicius);
            //}

            //Array.Sort(skaiciai);
            ////Console.WriteLine("Masyvo skaiciai didejancia tvarka: ");
            ////foreach (var skaicius in skaiciai)
            ////{
            ////    Console.WriteLine(skaicius);
            ////}
            //Console.WriteLine($"Maziausias skaicius masyve: {skaiciai[0]}");
            //Console.WriteLine($"Didziausias skaicius masyve: {skaiciai[9]}");

            //Nesukciaujant:



            //--------------------------------------------------- 5 UZDUOTIS ------------------------------------------------------

            //// 1 random array
            //int[] randomSkaiciai = new int[5];
            //Random random1 = new Random();
            //Console.WriteLine("PIRMAS random array: ");
            //for (int i = 0; i < randomSkaiciai.Length; i++)
            //{
            //    randomSkaiciai[i] = random1.Next(1, 47);
            //}
            //foreach (var randomSkaicius in randomSkaiciai)
            //{
            //    Console.WriteLine(randomSkaicius);
            //}

            //// 2 random array
            //int[] randomSkaiciai2 = new int[5];
            //Random random2 = new Random();
            //Console.WriteLine("ANTRAS random array: ");
            //for (int i = 0; i < randomSkaiciai2.Length; i++)
            //{
            //    randomSkaiciai2[i] = random2.Next(1, 47);
            //}
            //foreach (var randomSkaicius2 in randomSkaiciai2)
            //{
            //    Console.WriteLine(randomSkaicius2);
            //}

            //// Sujungtas array

            ////int[] sujungti = randomSkaiciai.Concat(randomSkaiciai2).ToArray();
            //int[] sujungti = new int[randomSkaiciai.Length + randomSkaiciai2.Length]; // nurodom kokio dyzdio bus array
            //randomSkaiciai.CopyTo(sujungti, 0); // 0 rodo nuo kurio indekso kopinam
            //randomSkaiciai2.CopyTo(sujungti, randomSkaiciai.Length); // tesim kopinima nuo to, kiek buvo random pirmam.

            //Console.WriteLine("Sujungti Array: ");
            //foreach (var item in sujungti)
            //{
            //    Console.WriteLine(item);
            //}
            //for (int i = 0; i < sujungti.Length; i++)// i = i+1 -- AREJAUS SORTINIMAS
            //{
            //    for (int j = i + 1; j < sujungti.Length; j++)// j = j  +1
            //    {
            //        if(sujungti[i] > sujungti[j]) //< daro nuo didziausio iki maziausio - padarius > duos nuo maziausio iki didziausio
            //        {
            //            int temp = sujungti[i];
            //            sujungti[i] = sujungti[j];
            //            sujungti[j] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine("Isrykiavus");

            //foreach (var item in sujungti)
            //{
            //    Console.WriteLine(item);
            //}

            //--------------------------------------------------- 6 uzduotis --------------------------------------------------------

            char[] zodis = new char[6];

            zodis[0] = 'K';
            zodis[1] = 'u';
            zodis[2] = 'r';
            zodis[3] = 's';
            zodis[4] = 'a';
            zodis[5] = 's';

            Console.WriteLine("Array versija pries isimant simboli: ");
            Console.WriteLine(zodis);

            char[] naujasZodis = new char[zodis.Length - 1];

            int m = 0;
            int n = 0;
            int removeAt = 4; // irasom kuri index is array isimsim

            while (m < zodis.Length)
            {
                if (m != removeAt)
                {
                    naujasZodis[n] = zodis[m];
                    n++;
                }
                m++;
            }

            Console.WriteLine("\nNaujas isvestas zodis: ");
            Console.WriteLine(naujasZodis); // isvedam gautas zodi

            #endregion

            #region LIST<T> TEORIJA

            List<string> listas = new List<string>();
            //Listo pildymas
            listas.Add("Jonas");
            listas.Add("Petras");
            listas.Add("Juozas");

            //Kitas budas papildyt lista
            List<string> listas2 = new List<string> { "Jonas", "Petras", "Juozas" };

            //isvedimui naudoja FOREACH arba FOR (naudojamt COUNT vietoj .Lenght)
            for (int i = 0; i < listas.Count; i++)
            {
                Console.WriteLine(listas[i]);
            }
            foreach (var item in listas)
            {
                Console.WriteLine(item);
            }

            listas.RemoveAt(5);//removina 5 itema
            listas.Insert(5, "Onute");
            listas.AddRange(listas2); // concatina abu listus.
            bool isContains = listas.Contains("Petras");
            //listas.REadonly nebeleidzia pridet nieko
            int indexas = listas.LastIndexOf("Patras");

            List<int> intList = new List<int>();
            List<bool> boolList = new List<bool>();
            List<object> objektlistas = new List<object>();//priima bet kokius tipus, bet uzsiknisi isimant info is ten

            objektlistas.Add(true);
            objektlistas.Add("true");

            boolList.Add(true);

            #endregion
        }
    }
}
