using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olio_ja_repository
{
    public class t6
    {

        //Fields


        //Properties
        public static string Artist;
        public static string Name;
        public static double Price;
        public static string Genre;
        public static int NrOfSongs;
        //Constructors
        public t6()
        {

        }

        //Methods

        public static void T6() //"Pääohjelma" jolla ajetaan luokan metodeja
        {
            t6 Thriller = new t6();
            Thriller.PrintInfo("Michael Jackson", "Thriller", 19.99, "Pop", 9);


        }

        public void PrintInfo(string artist, string name, double price, string genre, int nrofsongs)
        {
            Artist = artist;
            Name = name;
            Price = price;
            Genre = genre;
            NrOfSongs = nrofsongs;
            Console.WriteLine("Artist: " + Artist + "\nAlbum name: " + Name + "\nGenre: " + Genre + "\nPrice: " + Price + "\nNumber of songs: " + NrOfSongs);
        }


            
    }
}





