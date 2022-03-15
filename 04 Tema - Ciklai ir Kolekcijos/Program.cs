using System;

namespace _04_Tema___Ciklai_ir_Kolekcijos
{
    class Program
    {
        static void Main(string[] args)
        {
            //// PAPRASTAS CIKLAS 
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Sukasi ciklas. Siuo metu yra: {i}");
            //}
            //// MAZEJANTIS CIKLAS
            //for (int i = 10; i >=0; i--)
            //{
            //    Console.WriteLine($"Ciklas mazeja. Siuo metu yra: {i}");
            //}
            //// CIKLAS su ZINGSNIU
            //for (int i = 0; i < 10; i +=2) // kad kas antra skaiciuotu rasom "+=2"
            //{
            //    Console.WriteLine($"Sukasi ciklas. Siuo metu yra {i}");
            //}
            //// INTERACIJOS per SIMBOLIU DIAPOZONA
            //for (char i = 'a'; i <= 'z'; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // ITERACIJA per STRINGA
            string name = "Petriukas";
            int lenght = name.Length;
            for (int i = 0; i < name.Length; i++) // suks kiekviena raide kol pasibaigs vardo ilgis
            {
                char current = name[i];
                Console.WriteLine(current);
            }

            //// AMZINAS CIKLAS
            //while (true)
            //{
            //    Console.WriteLine("AMZINAI");
            //}

            //for (; ; )
            //{
            //    Console.WriteLine("AMZINAI");
            //}

            //PABEGIMAS is CIKLO
            for (int i = 0; i < name.Length; i++)
            {
                char current = name[i];
                if (current == 'u')
                {
                    break;
                }
                Console.WriteLine(current);
            }

            //CIKLO PRATESIMAS - CONTINUE
            for (int i = 0; i < name.Length; i++)
            {
                char current = name[i];
                if (current == 'u')
                {
                    continue; // neiseis, o pasiekes tikslas prades vel salyga nuo pradziu (iseina is IF ciklo ir tesia FOR cikla)
                }
                Console.WriteLine(current);
            }

            foreach (char simbolis in name)
            {
                var index = name.IndexOf(simbolis);
                Console.WriteLine(simbolis);
            }
        }
    }
}
