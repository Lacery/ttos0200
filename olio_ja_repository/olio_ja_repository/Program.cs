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
            int x = 10;
            for (int i = 0; i != x; i++)
            {
                Jasenet person1 = new Jasenet();
                Console.WriteLine("Kerro puheenjohtajan nimi: ");
                person1.Nimi = Console.ReadLine();
                Console.WriteLine("Kerro ika: ");
                person1.Ika = int.Parse(Console.ReadLine());
                person1.SanoNimi();
                person1.SanoIka();
            }
        }
    }


    class Jasenet
    {

        private int ika = 0;

        //Fields
        public string Nimi { get; set; }
        public int Ika {
            get; set;
        }


        //Constructor
        public Jasenet()
        {
        }


        //Methods
        public void SanoNimi()
        {
            Console.WriteLine("Nimi on " + Nimi);
        }
        public void SanoIka()
        {
            Console.WriteLine("Ika on " + Ika);
        }

    }


}