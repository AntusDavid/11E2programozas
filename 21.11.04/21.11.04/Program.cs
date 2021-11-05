using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2021._11._04
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            //feladat3();
            //feladat4();
            feladat5();//vízhalmazállapot
            feladat6();//üveggolyósszin
            //feladat7();
            //feladat8();
            //feladat9();
            //feladat10();
        }
        static void feladat1()
        {
            //kiírjuk az első 10 pozitív számot
            FileStream fs = new FileStream("kicsik1.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 1; i < 11; i++)
            {
                sw.WriteLine(i);
            }
            sw.Close();
            fs.Close();
            List<string> kiir = new List<string>();
            for (int i = 1; i < 11; i++)
            {
                kiir.Add(i.ToString());
            }
            File.WriteAllLines("kicsik2.txt", kiir);
        }
        static void feladat2()
        {
            FileStream fs = new FileStream("négyzet.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 1; i < 16; i++)
            {
                sw.WriteLine(i * i);
            }
            sw.Close();
            fs.Close();
        }
        static void feladat3()
        {
            FileStream fs = new FileStream("osztható_3-mal.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0)
                    sw.WriteLine(i);
            }
            sw.Close();
            fs.Close();
        }
        static void feladat4()
        {
            FileStream fs = new FileStream("vércsoportok.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < 51; i++)
            {
                switch (rnd.Next(1, 5))
                {
                    case 1:
                        sw.Write("A ");
                        break;
                    case 2:
                        sw.Write("B ");
                        break;
                    case 3:
                        sw.Write("AB  ");
                        break;
                    case 4:
                        sw.Write("0 ");
                        break;
                }
            }
            //alternatíva
            for (int i = 0; i < 51; i++)
            {
                switch (rnd.Next(1, 5))
                {
                    case 1:
                        File.AppendAllText("vércsoportok_alter.txt ", "A ");
                        break;
                    case 2:
                        File.AppendAllText("vércsoportok_alter.txt ", "B ");
                        break;
                    case 3:
                        File.AppendAllText("vércsoportok_alter.txt ", "AB ");
                        break;
                    case 4:
                        File.AppendAllText("vércsoportok_alter.txt ", "0 ");
                        break;
                }
            }
            sw.Close();
            fs.Close();
        }
        static void feladat5()
        {
            FileStream fs = new FileStream("vizhalmazállapot.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 1; i < 51; i++)
            {
                switch (rnd.Next(1,4))
                {
                    case 1:
                        sw.Write("szilárd ");
                        break;
                    case 2:
                        sw.Write("folyékony ");
                        break;
                    case 3:
                        sw.Write("légnemü ");
                        break;
                    default:
                        break;
                }

            }
            sw.Close();
            fs.Close();
        }
        static void feladat6()
        {

            FileStream fs = new FileStream("szin.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 1; i < 51; i++)
            {
                switch (rnd.Next(1, 11))
                {
                    case 1:
                        sw.Write("kék ");
                        break;
                    case 2:
                        sw.Write("zöld ");
                        break;
                    case 3:
                        sw.Write("piros ");
                        break;
                    case 4:
                        sw.Write("lila ");
                        break;
                    case 5:
                        sw.Write("fekete ");
                        break;
                    case 6:
                        sw.Write("fehér ");
                        break;
                    case 7:
                        sw.Write("barna ");
                        break;
                    case 8:
                        sw.Write("sárga ");
                        break;
                    case 9:
                        sw.Write("narancssárga ");
                        break;
                    case 10:
                        sw.Write("pink ");
                        break;
                    default:
                        break;
                }

            }
            sw.Close();
            fs.Close();
        }
        static void feladat7()
        {
            FileStream fs = new FileStream("vércsoportok_rh.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < 51; i++)
            {
                switch (rnd.Next(1, 5))
                {
                    case 1:
                        sw.Write("A ");
                        if (rnd.Next(1, 3) == 1)
                        {
                            sw.WriteLine("RH +");
                        }
                        else
                        {
                            sw.WriteLine("RH -");
                        }
                        break;
                    case 2:
                        sw.Write("B ");
                        if (rnd.Next(1, 3) == 1)
                        {
                            sw.WriteLine("RH +");
                        }
                        else
                        {
                            sw.WriteLine("RH -");
                        }
                        break;
                    case 3:
                        sw.Write("AB  ");
                        if (rnd.Next(1, 3) == 1)
                        {
                            sw.WriteLine("RH +");
                        }
                        else
                        {
                            sw.WriteLine("RH -");
                        }
                        break;
                    case 4:
                        sw.Write("0 ");
                        if (rnd.Next(1, 3) == 1)
                        {
                            sw.WriteLine("RH +");
                        }
                        else
                        {
                            sw.WriteLine("RH -");
                        }
                        break;
                }
            }
            //alternatíva
            for (int i = 0; i < 51; i++)
            {
                switch (rnd.Next(1, 5))
                {
                    case 1:
                        File.AppendAllText("vércsoportok_rh_alter.txt ", "A ");
                        if (rnd.Next(1, 3) == 1)
                        {
                            File.AppendAllText("vércsoportok_rh_alter.txt ", "RH +\r");
                        }
                        else
                        {
                            File.AppendAllText("vércsoportok_rh_alter.txt ", "RH -\r");
                        }
                        break;
                    case 2:
                        File.AppendAllText("vércsoportok_rh_alter.txt ", "B ");
                        if (rnd.Next(1, 3) == 1)
                        {
                            File.AppendAllText("vércsoportok_rh_alter.txt ", "RH +\r");
                        }
                        else
                        {
                            File.AppendAllText("vércsoportok_rh_alter.txt ", "RH -\r");
                        }
                        break;
                    case 3:
                        File.AppendAllText("vércsoportok_rh_alter.txt ", "AB ");
                        if (rnd.Next(1, 3) == 1)
                        {
                            File.AppendAllText("vércsoportok_rh_alter.txt ", "RH +\r");
                        }
                        else
                        {
                            File.AppendAllText("vércsoportok_rh_alter.txt ", "RH -\r");
                        }
                        break;
                    case 4:
                        File.AppendAllText("vércsoportok_rh_alter.txt ", "0 ");
                        if (rnd.Next(1, 3) == 1)
                        {
                            File.AppendAllText("vércsoportok_rh_alter.txt ", "RH +\r");
                        }
                        else
                        {
                            File.AppendAllText("vércsoportok_rh_alter.txt ", "RH -\r");
                        }
                        break;
                }
            }
            sw.Close();
            fs.Close();
        }
        static void feladat8()
        {

        }
        static void feladat9()
        {

        }
        static void feladat10()
        {

        }
    }
}

