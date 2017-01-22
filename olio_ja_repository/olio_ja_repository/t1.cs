using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace olio_ja_repository
{

    public class t1
    {
        public static void T1()
        {
            int[] luvut = new int[5];
            int yhteensa;

            for (int i = 0; i <= 4; i++)
            {

                Console.WriteLine("Anna pisteet: ");
                luvut[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Pienin pistemaara: " + luvut.Min());
            Console.WriteLine("Suurin pistemaara: " + luvut.Max());

            int sum = luvut.Sum();

            yhteensa = sum - luvut.Min() - luvut.Max();
            Console.WriteLine("Kokonaispisteet: " + yhteensa);


        }
    }
}
