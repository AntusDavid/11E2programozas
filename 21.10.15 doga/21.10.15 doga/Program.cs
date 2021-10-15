using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._10._15_doga
{
    class Program
    {
        static void Main(string[] args)
        {
            feladat1();
            //feladat2();
            //feladat3();
            //feladat4();
            //feladat5();
            Console.WriteLine("       Kilépés enter.");
            Console.ReadKey();
        }
        static void feladat1()
        {
            Console.Write("Add meg a téglalap egyik oldalát: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Add meg a téglalap másik oldalát: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("A téglalap kerülete: {0}",2*a+2*b); 
            Console.WriteLine("A téglalap területe: {0} ",a*b);


        }
        static void feladat2()
        {
            Console.Write("Add meg az évet: ");
            double a = double.Parse(Console.ReadLine());
            if (a%4==0)
            {
                Console.WriteLine("A meg adott év szökőév.");
            }
            else
            {
                Console.WriteLine("A megadott év nem szökőév.");
            }
        }
        static void feladat3()
        {
            Console.Write("Adj meg egy számot 1-7között: ");
            double a = double.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Hétfő.");
                    break;
                case 2:
                    Console.WriteLine("Kedd.");
                    break;
                case 3:
                    Console.WriteLine("Szerda.");
                    break;
                case 4:
                    Console.WriteLine("Csütörtök.");
                    break;
                case 5:
                    Console.WriteLine("Péntek.");
                    break;
                case 6:
                    Console.WriteLine("Szombat.");
                    break;
                case 7:
                    Console.WriteLine("Vasárnap.");
                    break;
                default:
                    Console.WriteLine("Nem a megadott számok közül választott!");
                    break;
            }
        }
        static void feladat4()
        {
            for (int i = 40; i>= -110 ; i= i-7)
            {
                Console.Write("{0} ",i);
            }
        }
        static void feladat5()
        {
            Console.Write("Adj meg egy pozitiv egész számot: ");
            double a = double.Parse(Console.ReadLine());
            for (int i = 1; i < a;i= i+2)
            {
                Console.Write("{0} ",i);
            }

        }
    }
}
