﻿
using System;
using olio_ja_repository;
namespace Hello_Word
{
    class Program
    {
        static void Main(string[] args)
        {

            t5 student = new t5(22, "Ville", "ICT", false);
            t5.PrintInfo();

            t5 student1 = new t5(53, "Markku", "-", true);
            t5.PrintInfo();

        }
    }
}





/*
using System;
using olio_ja_repository;
namespace Hello_Word
{
    class Program
    {
        static void Main(string[] args)
        {

            int nro;
            Console.WriteLine("Mikä tehtävä ajetaan?");
            nro = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (nro)
            {
                default: Console.WriteLine("Ei kelvollinen tehtävänumero. Sammutetaan."); break;
                case 1: t1.T1(); break;
                case 2: t2.T2(); break;
                case 3: t3.T3(); break;
                case 4: t4.T4(); break;
                case 5: t5.T5(); break;
            }
        }
    }
}

*/
