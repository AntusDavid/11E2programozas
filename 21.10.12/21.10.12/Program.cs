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
            feladat4();
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
    }
}
