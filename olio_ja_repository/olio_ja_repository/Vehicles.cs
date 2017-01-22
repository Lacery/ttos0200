using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{

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
