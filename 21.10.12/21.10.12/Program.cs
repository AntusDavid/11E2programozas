using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._10._12
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1a();
            //feladat1b();
            //feladat2();
            //feladat3a();
            //feladat3b();
            //feladat4();
            //feladat5();
            //feladat6();
            //feladat7();
            //feladat8();
            //feladat9();
            feladat10();
            Console.WriteLine("       Kilépés enter.");
            Console.ReadKey();
        }
        static void feladat1a()
        {
            for (int i = 1; i < 21; i = i+1)
            {
                Console.Write("{0} ",i);
            }
        }
        static void feladat1b()
        {
            for (int i = 1; i < 21; i = i + 1)
            {
                Console.Write("{0} ", i);
                Console.WriteLine(" ");
            }

        }
        static void feladat2()
        {
            for (int i = 15; i <93 ; i = i+1)
            {
                Console.Write("{0} ", i);
            }
        }
        static void feladat3a()
        {

            for (int i = 1; i < 30; i = i+1)
            {
                if (i%2==0)
                {
                Console.Write("{0} ", i);
                }
            }
        }
        static void feladat3b()
        {

            for (int i = 1; i < 30; i = i + 1)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0} ", i);
                }
            }

        }
        static void feladat4()
        {
            Console.Write("Adj meg egy poziziv egész számot: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                for (int i = 1; i < a; i++)
                {
                    Console.Write("{0} ",i);
                }
            }
            else
            {
                Console.WriteLine("A(z) {0} nem pozitiv szám.");
            }
        }
        static void feladat5()
        {
            Console.Write("Adj meg egy poziziv egész számot: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                for (int i = 1; i < a; i++)
                {
                    Console.WriteLine("{0} ", i);
                }
            }
            else
            {
                Console.WriteLine("A(z) {0} nem pozitiv szám.");
            }
        }
        static void feladat6()
        {
            for (int i = 1; i <16 ; i++)
            {
                int a = i * 2;
                Console.WriteLine("{0} ",a);
            }
        }
        static void feladat7()
        {
            for (int i = 100; i < 401; i++)
            {
                if (i%4==0)
                {
                    Console.WriteLine("{0} ", i);
                }
            }
        }
        static void feladat8()
        {
            for (int i = 30; i < 101; i = i+9)
            {
                Console.WriteLine("{0} ", i);
            }
        }
        static void feladat9()
        {
            for (int i = 150; i > 40; i = i - 12)
            {
                Console.WriteLine("{0} ", i);
            }

        }
        static void feladat10()
        {
            for (int i = 100; i > -100; i--)
            {
                if (i%9==0)
                {
                    Console.WriteLine("{0} ",i);
                }
            }
        }
    }
}
