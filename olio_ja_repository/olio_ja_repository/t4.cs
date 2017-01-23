using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace Hello_Word
{
    class t4
    {
        public static void T4()
        {
            Vehicle vehje = new Vehicle("Auto", 120, 4);
            vehje.PrintData();
            Console.WriteLine(vehje.ToString() + "\n");


            Vehicle rekka = new Vehicle("rekka", 100, 6);
            rekka.PrintData();
            Console.WriteLine(rekka.ToString());

        }
    }
    public class Vehicle
    {

        //Fields


        //Properties
        public string Name;
        public int Speed;
        public int Tyres;

        //Constructors
        public Vehicle(string name, int speed, int tyres)
        {
            Name = name;
            Speed = speed;
            Tyres = tyres;

        }


        //Methods

        public void PrintData()
        {
            Console.WriteLine(Name + "\n" + Speed + "\n" + Tyres);
        }

        public string ToString()
        {
            string properties = String.Concat(Name, Speed, Tyres);
            return properties;
        }
    }



}