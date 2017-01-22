using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olio_ja_repository
{
    class t6
    {
        public static void T6()
        {
            string sana;
            Console.WriteLine("Syota sana: ");
            sana = Console.ReadLine();
            if (Palindromi(sana) == true) //Kutsutaan aliohjelma
                Console.WriteLine("On palindromi");
            else
                Console.WriteLine("Ei ole");


        }
        public static bool Palindromi(string merkkijono)
        {
            int i = 0; //Ensimmäinen kirjain
            int j = merkkijono.Length - 1; //Viimeinen kirjain
            while (true)
            {
                if (i > j)
                {
                    return true;
                }
                char a = merkkijono[i];
                char b = merkkijono[j];
                if (char.ToLower(a) != char.ToLower(b)) //Jos sanan päädystä yhtä kaukana olevat kirjaimet eivät ole samoja, false = ei palindromi
                {
                    return false;
                }
                i++; //Kokeillaan 2. kirjain seuraavaksi
                j--; //Kokeillaan 2. viimeinen seuraavaksi
            }
        }
    }
}
