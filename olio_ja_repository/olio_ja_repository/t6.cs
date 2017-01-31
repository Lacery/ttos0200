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
            Disk Levy = new CD(2007, "Victory Songs", 20);
            Console.WriteLine(Levy.ToString());


            Disk BluRay = new BluRay(2005, "Frozen", new string[] { "Eka" , "toka", "kolmas" });
            Console.WriteLine(BluRay.ToString());

        }
    }

    class Disk
    {

        public string Name { get; set; }
        public int Year { get; set; }

        public Disk()
        {

        }
        public Disk(int year, string name)
        {
            Year = year;
            Name = name;
        }
        public virtual string ToString()
        {
            return "Name: " + Name + "\nYear: " + Year + "\n";
        }


    }

    class CD : Disk
    {

        public int SongAmount { get; set; }

        public CD(int year, string name, int songamount) :base(year,name)
        {
            SongAmount = songamount;
        }

        public override string ToString()
        {
            return base.ToString() + "Number of songs: " + SongAmount + "\n";
        }

    }


    class BluRay : Disk
    {

        public string[] Scenes;

        public BluRay(int year, string name, string[] scenes) :base(year,name)
        {
            Scenes = scenes;
        }

        public override string ToString()
        {
            return base.ToString() + "Kohtaukset: " + Scenes[0] + Scenes[1] + Scenes[2];
        }


    }



}
