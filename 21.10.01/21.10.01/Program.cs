using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._10._01
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            //feladat3();
            //feladat4();
            //feladat5();
            //feladat6();
            //feladat7();
            //feladat8();
            //feladat9();
            //feladat10();
            //feladat11();
            //feladat12();
            //feladat13();
            //feladat14();
            //feladat15();
            //feladat16();
            //feladat17();
            //feladat18();
            Console.WriteLine("enter");
            Console.ReadLine();
        }
        static void feladat1()
        {
            Console.WriteLine("Hello world!");
        }
        static void feladat2()
        {
            Console.Write("Add meg a neved!");
            string nev = Console.ReadLine();
            Console.WriteLine("Szia {0}",nev);

        }
        static void feladat3()
        {

        }
        static void feladat4()
        {
            Console.Write("Adj meg egy számot: ");
            double a = double.Parse(Console.ReadLine());
            double b = 2 * a;
            Console.WriteLine("A megadott szám kétszerese: {0}",b);
        }
        static void feladat5()
        {
            Console.Write("Add meg az első számot: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Addd meg a második számot: ");
            double b = double.Parse(Console.ReadLine());
            double c = a + b;
            double d = a - b;
            if (a!=0 & b!=0)
            {
                double e = a / b;
                Console.WriteLine("A számaid hányadosa: {0}",e );
            }
            else
            {
                Console.WriteLine("Nem értelmezhető az osztás mivel az egyik számod nulla!");
            }
            Console.WriteLine("A megadott számok összege: {0}",c);
            Console.WriteLine("A megadott számok különbsége: {0}", d);

        }
        static void feladat6()
        {
            Console.Write("Kérem a négyzet oldalát! a=");
            double a = double.Parse(Console.ReadLine());
            double k = 4 * a;
            Console.WriteLine("A négyzet kerülete {0}",k);
            double t = a * a;
            Console.WriteLine("A négyzet területe {0}", t);
            t = Math.Pow(a, 2);
            Console.WriteLine("A négyzet területe {0}", t);
        }
        static void feladat7()
        {

        }
        static void feladat8()
        {

        }
        static void feladat9()
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            int c = int.Parse(Console.ReadLine());
            int legkisebb = Math.Min(a, Math.Min(b, c));
            Console.WriteLine("A leg kisseb szám: {0}",legkisebb);
        }
        static void feladat10()
        {

        }
        static void feladat11()
        {

        }
        static void feladat12()
        {

        }
        static void feladat13()
        {

        }
        static void feladat14()
        {

        }
        static void feladat15()
        {

        }
        static void feladat16()
        {

        }
        static void feladat17()
        {

        }
        static void feladat18()
        {

        }
    }
}
