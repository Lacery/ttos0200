using System;
using Vehicles;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace Hello_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehje = new Vehicle("Auto", 120, 4);
            vehje.PrintData();
            Console.WriteLine(vehje.ToString());


            Vehicle rekka = new Vehicle("rekka", 100, 6);
            rekka.PrintData();
            Console.WriteLine(rekka.ToString());

        }
    }




}