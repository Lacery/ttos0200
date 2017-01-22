using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olio_ja_repository
{
    class t7
    {
        public static void T7()
        {
            string hidden_word = "---";
            string[] used_letters = new string[28];
            char guess;
            StringBuilder sb = new StringBuilder(hidden_word);


            for (int i = 0; true; i++)
            {
                Console.Clear();
                Console.WriteLine("Arvaa kirjain: ");
                guess = char.Parse(Console.ReadLine());
                used_letters[i] += guess;

                if (guess == 'm')
                {
                    sb[0] = guess;
                    hidden_word = sb.ToString();
                    Console.WriteLine("Oikein!\n" + hidden_word + "\nKaytetyt kirjaimet: ");
                    for (int j = 0; j <= hidden_word.Length; j++)
                    {
                        Console.Write(used_letters[j]);
                    }
                    Console.ReadLine();
                }
                if (guess == 'o')
                {
                    sb[1] = guess;
                    hidden_word = sb.ToString();
                    Console.WriteLine("Oikein!\n" + hidden_word + "\nKaytetyt kirjaimet: ");
                    for (int j = 0; j <= hidden_word.Length; j++)
                    {
                        Console.Write(used_letters[j]);
                    }
                    Console.ReadLine();
                }
                if (guess == 'i')
                {
                    sb[2] = guess;
                    hidden_word = sb.ToString();
                    Console.WriteLine("Oikein!\n" + hidden_word + "\nKaytetyt kirjaimet: ");
                    for (int j = 0; j <= hidden_word.Length; j++)
                    {
                        Console.Write(used_letters[j]);
                    }
                    Console.ReadLine();
                }
                if (i == 10)
                {
                    Console.WriteLine("Sinut hirtettiin, fuck u");
                    break;
                }
            }

        }
    }
}
