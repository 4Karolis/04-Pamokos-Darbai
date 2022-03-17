using System;

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
            //Console.WriteLine("\nSuma tarp visu jusu ivestu skaicu (imtinai) yra: {0}", suma);
            //Console.WriteLine($"\nVisu skaiciu tarp {pirmas} ir {antras} suma (imtinai) yra: {suma}");//SAME


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

            for (; ; )
            {
                double num1, num2, pasirinkimas;
                while (true)
                {
                    Console.WriteLine("Iveskite pirma skaiciu: ");
                    if (double.TryParse(Console.ReadLine(), out num1))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Neteisingai ivestas skaicius. Bandykite dar karta.");
                    }
                }
                while (true)
                {
                    Console.WriteLine("Iveskite antra skaiciu: ");
                    if (double.TryParse(Console.ReadLine(), out num2))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Neteisingai ivestas skaicius. Bandykite dar karta.");
                    }
                }
                while (true)
                {
                    Console.WriteLine("Pasirinkite koki veiksma norite atlikti: \n1 - Sudetis; 2 - Atimtis; 3 - Daugyba; 4 - Dalyba;");
                    if (double.TryParse(Console.ReadLine(), out pasirinkimas))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Neteisingai ivestas skaicius. Bandykite dar karta.");
                    }
                }

                double suma = num1 + num2;
                double atimtis = num1 - num2;
                double daugyba = num1 * num2;
                double dalyba = num1 / num2;

                switch (pasirinkimas)
                {
                        case 1:
                        Console.WriteLine($"{num1} + {num2} = {suma}");
                        break;
                    case 2:
                        Console.WriteLine($"{num1} - {num2} = {atimtis}");
                        break;
                    case 3:
                        Console.WriteLine($"{num1} * {num2} = {daugyba}");
                        break;
                    case 4:
                        Console.WriteLine($"{num1} / {num2} = {dalyba}");
                        break;
                    default:
                        Console.WriteLine("Ivestas neteisingas pasirinkimas. Bandykite dar karta");
                        break;
                }

                Console.WriteLine("Noredami testi spauskite 't', noredami iseiti is programos spauskite 'ENTER' arba bet kuri kita mygtuka");
                string testi = Console.ReadLine();
                //testi.Equals((testi), StringComparison.OrdinalIgnoreCase); Console.ReadLine();
                bool valid = testi == "t" || testi == "T";
                if (!valid)
                {
                    Console.WriteLine("Aciu kad naudojates musu paslaugomis. Iki kito karto!");
                    break;
                }

            }
            //-------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
