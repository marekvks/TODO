using System;
using System.Collections.Generic;

namespace TODO
{
    class Program
    {
        public static List<string> listik = new List<string>();

        static void Main(string[] args)
        {
            bool endloop = false;


            while (endloop == false)
            {
                Console.WriteLine("TODO\n\n");
                Console.WriteLine("1) Vypsat ukoly");
                Console.WriteLine("2) Přidat ukol");
                Console.WriteLine("3) Odebrat ukol\n\n");

                string userInput = Console.ReadLine();
                Console.Clear();

                switch (userInput)
                {
                    case "1":
                        FunkceVypisovani();
                        break;
                    case "2":
                        FunkcePridavani();
                        break;
                    case "3":
                        FunkceOdebirani();
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }

        static void FunkceVypisovani()
        {
            if (listik.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNemas zadne ukoly");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine($"\nZde je seznam vasich ukolu, mate {listik.Count} ukol/y\n");
                for (int i = 0; i < listik.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {listik[i]}");
                }
            }

            Console.WriteLine("\nstisknete jakekoliv tlacitko pro pokracovani");
            Console.ReadKey();
            Console.Clear();
        }

        static void FunkcePridavani()
        {
            Console.Write("Přidat úkol: ");
            listik.Add(Console.ReadLine());
            Console.WriteLine("\nUkol uspesne pridan!\n");
            Console.WriteLine("stisknete jakekoliv tlacitko pro pokracovani");
            Console.ReadKey();
            Console.Clear();
        }

        static void FunkceOdebirani()
        {
            Console.Write("napište číslo úkolu, který chcete odstranit: ");
            int indexOdstraneni;
            try
            {
                indexOdstraneni = Convert.ToInt32(Console.ReadLine());
                indexOdstraneni -= 1;
                listik.RemoveAt(indexOdstraneni);
                Console.WriteLine("\nUkol uspesne odstranen!");
                Console.WriteLine("\nstisknete jakekoliv tlacitko pro pokracovani");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception e)
            {
                Console.WriteLine("\nZapsal jsi spatny index nebo nemas zadne ukoly\n");
                Console.WriteLine("stisknete jakekoliv tlacitko pro pokracovani");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}