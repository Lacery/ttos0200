using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olio_ja_repository
{
    class t4
    {
        public static void T4()
        {
            Random rnd = new Random();
            int numero = rnd.Next(0, 100);
            int arvaus;


            for (int i = 0; true; i++)
            {
                Console.WriteLine("Arvaa numero: ");
                arvaus = int.Parse(Console.ReadLine());

                if (arvaus == numero)
                {
                    Console.WriteLine("Onneksi olkoon, oikea numero!");
                    Console.WriteLine("Arvausten maara: " + (i + 1));
                    break;
                }

                if (arvaus > numero)
                {
                    Console.WriteLine("Numero on pienempi kuin arvauksesi!");
                }
                if (arvaus < numero)
                {
                    Console.WriteLine("Numero on suurempi kuin arvauksesi!");
                }

            }


        }
    }
}
