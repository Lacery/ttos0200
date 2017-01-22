using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olio_ja_repository
{
    class t5
    {
        public static void T5()
        {

            int[] taulukko1 = new int[5] { 10, 20, 30, 40, 50 };
            int[] taulukko2 = new int[5] { 5, 15, 25, 35, 45 };


            var luvut = new List<int>();  //Laitetaan taulukot listaan ja yhdistetään ne
            luvut.AddRange(taulukko1);
            luvut.AddRange(taulukko2);

            int[] taulukko3 = luvut.ToArray(); //Laitetaan listan sisältö taulukko3:een

            Array.Sort(taulukko3, (y, x) => y.CompareTo(x)); //Järjestää suuruusjärjestykseen

            foreach (int numero in taulukko3) //Tulostaa taulukon
            {
                Console.WriteLine(numero);
            }
        }
    }
}
