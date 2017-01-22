using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olio_ja_repository
{
    class t3
    {
        public static void T3()
        {
            int kerros, valilyonnit, tahdet, i;
            char merkki = '*';
            Console.WriteLine("Kuinka korkea puu tehdaan?");
            kerros = int.Parse(Console.ReadLine());
            for (i = 1; i <= kerros - 2; i++) // Kerrosten määrä
            {
                for (valilyonnit = 1; valilyonnit <= (kerros - 2 - i); valilyonnit++)  // Välilyönnit jotta saadaan puun muoto
                    Console.Write(" ");
                for (tahdet = 1; tahdet <= i; tahdet++) //Vasen puoli ja "keskiosa"
                    Console.Write(merkki);
                for (tahdet = (i - 1); tahdet >= 1; tahdet--)  //Oikea puoli
                    Console.Write(merkki);
                Console.WriteLine();
            }
            string[] tyhjat = new string[kerros];
            for (int h = 0; h <= i - 3; h++)  //Määrittää montako väliä tulee ennen "runkoa"
            {
                tyhjat[h] += " ";
            }
            for (int j = 1; j <= 2; j++) //Tulostaa rungon
            {
                for (int k = 0; k <= i - 2; k++) //Tulostaa välit runkoon asti
                {
                    Console.Write(tyhjat[k]);
                }
                Console.WriteLine("*");
            }
        }
    }
}