using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._10._08
{
    class Program
    {
        static void Main(string[] args)
        {
            //mintafeladat();
            feladat12();
            //feladat13();
            //feladat14();
            //feladat15();
            //feladat16();
            Console.WriteLine("enter");
            Console.ReadLine();

        }
        static void mintafeladat()
        {
            Console.WriteLine("Kávéautomata");
            Console.WriteLine(" A: epresso");
            Console.WriteLine(" B: latte macchiato");
            Console.WriteLine(" C: espresso macchiato");
            Console.WriteLine(" D: cappucino");
            Console.WriteLine(" E: bécsi kávé");
            Console.WriteLine(" F: ristretto");
            Console.WriteLine(" G: forró csoki");
            Console.Write("Válasz egy terméket (A-G): ");
            char valasztas = char.Parse(Console.ReadLine());
            switch (valasztas)
            {
                case 'A':
                case 'a':
                    Console.WriteLine("Az espreso ára: 130 Ft.");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("A latte macchiato ára: 150Ft");
                    break;
                case 'C':
                case 'c':
                    Console.WriteLine("Az espresso macchiato ára 140Ft");
                    break;
                case 'D':
                case 'd':
                    Console.WriteLine("A capucino ára 140Ft");
                    break;
                case 'E':
                case 'e':
                    Console.WriteLine("A bécsi kávé ára 120Ft");
                    break;
                case 'F':
                case 'f':
                    Console.WriteLine("A ristretto ára 140Ft");
                    break;
                case 'G':
                case 'g':
                    Console.WriteLine("A forró csoki ára 180Ft");
                    break;
                default:
                    Console.WriteLine("Nincs ilyen termék.");
                    break;
            }
            switch (valasztas.ToString().ToLower()) // szöveg tipus lett
            {
                case "A":
                case "a":
                    Console.WriteLine("Az espreso ára: 130 Ft.");
                    break;
                case "B":
                case "b":
                    Console.WriteLine("A latte macchiato ára: 150Ft");
                    break;
                case "C":
                case "c":
                    Console.WriteLine("Az espresso macchiato ára 140Ft");
                    break;
                case "D":
                case "d":
                    Console.WriteLine("A capucino ára 140Ft");
                    break;
                case "E":
                case "e":
                    Console.WriteLine("A bécsi kávé ára 120Ft");
                    break;
                case "F":
                case "f":
                    Console.WriteLine("A ristretto ára 140Ft");
                    break;
                case "G":
                case "g":
                    Console.WriteLine("A forró csoki ára 180Ft");
                    break;
                default:
                    Console.WriteLine("Nincs ilyen termék.");
                    break;
            }
        }
        static void feladat12()
        {
            Console.Write("Add meg a  honap számát: ");
            int honap = new int();
            switch (honap)
            {
                case 1:
                    Console.WriteLine("Jamuár");
                    break;
                case 2:
                    Console.WriteLine("Február");
                    break;
                case 3:
                    Console.WriteLine("Március");
                    break;
                case 4:
                    Console.WriteLine("Április");
                    break;
                case 5:
                    Console.WriteLine("Május");
                    break;
                case 6:
                    Console.WriteLine("Június");
                    break;
                case 7:
                    Console.WriteLine("Július");
                    break;
                case 8:
                    Console.WriteLine("Augusztus");
                    break;
                case 9:
                    Console.WriteLine("Szeptember");
                    break;
                case 10:
                    Console.WriteLine("Oktober");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("Daecember");
                    break;
                default:
                    Console.WriteLine("Nem létezik a számnak megfelelő hónap.");
                    break;

            }
        }
        static void feladat13()
        {
            Console.Write("Addd meg a hónapot: ");
            int honap = new int();
            switch (honap)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Tél");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Tavasz");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Nyár");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Ösz");
                    break;
                default:
                    Console.WriteLine("Nincs ilyen hónap");
                    break;
            }
        }
        static void feladat14()
        {
            Console.Write("Add meg a számot: ");
            int szam = new int();
            switch (szam.ToString().Length)
            {
                case 1:
                    Console.WriteLine("Egy jegyü.");
                    break;
                case 2:
                    Console.WriteLine("Két jegyü.");
                    break;
                case 3:
                    Console.WriteLine("Három jegyü.");
                    break;
                case 4:
                    Console.WriteLine("Négy jegyü.");
                    break;
                case 5:
                    Console.WriteLine("Öt jegyü.");
                    break;
                default:
                    Console.WriteLine("6 vagy annál több.");
                    break;
            }
        }
        static void feladat15()
        {
            Console.Write("Add meg a jegyet:");
            int jegy = new int();
            switch (jegy)
            {
                case 1:
                    Console.WriteLine("Nem meg felelő.");
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Megfelelő.");
                    break;
                default:
                    Console.WriteLine("Nincs ilyen jegy a magyar oktatásban.");
                    break;
            }
        }
        static void feladat16()
        {
            Console.Write("Add meg a jegyet.");
            int jegy = new int();
            switch (jegy)
            {
                case 1:
                    Console.WriteLine("Elégtelen.");
                    break;
                case 2:
                    Console.WriteLine("Elégséges.");
                    break;
                case 3:
                    Console.WriteLine("Közepes.");
                    break;
                case 4:
                    Console.WriteLine("Jó.");
                    break;
                case 5:
                    Console.WriteLine("Jeles.");
                    break;
                default:
                    Console.WriteLine("Nincs ilyen jegy a magyar oktatásban.");
                    break;

            }

        }
    }

}
