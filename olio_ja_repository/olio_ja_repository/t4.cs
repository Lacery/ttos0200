using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olio_ja_repository
{
    class t4
    {
        public static void T4()
        {
            Vehicle Auto1 = new Vehicle("Nissan", "Micra", 1998, "Punainen");
            Vehicle Laiva = new Boat("Viking Line", "Baltic Queen", 1995, "Valkoinen", "Valtamerilaiva", 20000);
            Bike bike = new Bike("Helkama", "Tango", 2005, "Musta", true, "Vaihdesetti");

            Console.WriteLine(Auto1.ToString());
            Console.WriteLine(bike.ToString());
            Console.WriteLine(Laiva.ToString());


        }
    }

    class Vehicle
    {
        //Properties
        public string Name { get; set;}
        public string Model { get; set; } 
        public int Year { get; set; }
        public string Color { get; set; }

        //Constructors
        public Vehicle()
        {

        }
        public Vehicle(string name, string model, int year, string color)
        {
            Name = name; Model = model; Year = year; Color = color;
        }


        //Methods
        public virtual string ToString()
        {
          return "Name: " + Name + "\nModel: " + Model + "\nYear: " + Year + "\nColor: " + Color + "\n";
        }
    }

    class Bike : Vehicle
    {
        public bool Gear {get; set; }
        public string GearName { get; set; }


        public Bike(string name, string model, int year, string color, bool gear, string gearname ) :base(name, model, year, color)
        {
            Gear = gear;
            GearName = gearname;
        }

        public override string ToString()
        {
            return base.ToString() + "Gear: "+ Gear + "\nGear Name: " + GearName + "\n";
        }

    }

    class Boat : Vehicle
    {
        public string Type { get; set; }
        public int Seats { get; set; }

        public Boat(string name, string model, int year, string color, string type, int seats) :base(name, model, year, color)
        {
            Type = type;
            Seats = seats;
        }


        public override string ToString()
        {
            return base.ToString() + "Type: " + Type + "\nSeats: " + Seats + "\n";
        }
    }

}
