using System;
using Televisioclassi;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace Hello_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Televisio LG = new Televisio("LG", "Black", 45, "1920x1080");

            LG.PrintInfo();
            LG.SwitchChannel();
            LG.ChangeVolume(5);

            Console.WriteLine();

            Televisio Samsung = new Televisio("Samsung", 6, 25);
            Samsung.PrintInfo();
        }
    }




}