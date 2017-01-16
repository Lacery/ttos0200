using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Hello_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int kerros, Space, Number, i = 1;
            char merkki = '*';
            Console.WriteLine("Montako kerrosta?");
            kerros = int.Parse(Console.ReadLine());
            for (i = 1; i <= kerros; i++) // Kerrosten määrä
            {
                for (Space = 1; Space <= (kerros - i); Space++)  // Välilyönnit jotta saadaan puun muoto
                    Console.Write(" ");
                for (Number = 1; Number <= i; Number++) //Vasen puoli
                    Console.Write(merkki);
                for (Number = (i - 1); Number >= 1; Number--)  //Oikea puoli
                    Console.Write(merkki);
                Console.WriteLine();
            }
            //Console.WriteLine(i);
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