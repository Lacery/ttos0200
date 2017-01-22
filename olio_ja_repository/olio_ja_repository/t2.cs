using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olio_ja_repository
{
    class t2
    {
        public static void T2()
        {
            int arvosana, maara;
            Console.WriteLine("Montako arvosanaa syotat?");
            maara = int.Parse(Console.ReadLine());

            string[] nollat = new string[maara];
            string[] ykkoset = new string[maara];
            string[] kakkoset = new string[maara];
            string[] kolmoset = new string[maara];
            string[] neloset = new string[maara];
            string[] vitoset = new string[maara];

            for (int i = 0; i <= maara - 1; i++)
            {
                Console.WriteLine("\nAnna arvosana (0-5): ");
                arvosana = int.Parse(Console.ReadLine());


                switch (arvosana)
                {
                    case 0:
                        nollat[i] += "*";
                        break;
                    case 1:
                        ykkoset[i] += '*';
                        break;
                    case 2:
                        kakkoset[i] += '*';
                        break;
                    case 3:
                        kolmoset[i] += '*';
                        break;
                    case 4:
                        neloset[i] += '*';
                        break;
                    case 5:
                        vitoset[i] += '*';
                        break;
                    default:
                        Console.WriteLine("Virheellinen numero");
                        i--;
                        break;

                }
            }
            Console.Write("0: ");
            nollat.ToList().ForEach(Console.Write);
            Console.Write("\n1: ");
            ykkoset.ToList().ForEach(Console.Write);
            Console.Write("\n2: ");
            kakkoset.ToList().ForEach(Console.Write);
            Console.Write("\n3: ");
            kolmoset.ToList().ForEach(Console.Write);
            Console.Write("\n4: ");
            neloset.ToList().ForEach(Console.Write);
            Console.Write("\n5: ");
            vitoset.ToList().ForEach(Console.Write);
            Console.WriteLine("\n");


        }
    }
}
