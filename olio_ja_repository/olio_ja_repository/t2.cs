using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace olio_ja_repository
{

    public class t2
    {
        public static void T2()
        {

            CD cd = new CD("Rammstein", 18.99, "Du hast", 4.32);
            Console.WriteLine(cd.ToString());

            cd.PrintSongs();


        }

    }
    
    class CD
    {

        public string Artist { get; set; }
        public double Price { get; set; }
        List<Song> songs = new List<Song>();

        public CD(string artist, double price, string songname, double songlength)
        {
            Artist = artist;
            Price = price;
            songs.Add(new Song { Name = songname, Length = songlength });
        }

        public void AddCD() //Tällä?
        {

        }

        public override string ToString()
        {
            return "Artist: " + Artist + "\nPrice: " + Price + "\nSongs: ";
        }

        public void PrintSongs()
        {
            foreach (Song song in songs)
            {
                Console.WriteLine(song.Name + " " + song.Length);
            }
        }


    }
    
    

    class Song
    {
        public string Name { get; set; }
        public double Length { get; set; }





    }


}
