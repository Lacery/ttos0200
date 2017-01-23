using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace Hello_Word
{
    class t1
    {
        public static void T1()
        {
            Kiuas hehku = new Kiuas();

            hehku.Power_on();
            hehku.ChangeHumid();
            hehku.ChangeTemp();
            hehku.Power_off();
        }
    }


    class Kiuas
    {

        //Fields
        public string state;
        public float humidity, temperature;


        //Constructor
        public Kiuas()
        {
        }


        //Methods
        public void Power_off()
        {
            state = "off";
            Console.WriteLine("State of kiuas is " + state);
        }
        public void Power_on()
        {
            state = "on";
            Console.WriteLine("State of kiuas is " + state);
        }
        public void ChangeHumid()
        {
            Console.WriteLine("Anna uusi kosteus: ");
            humidity = float.Parse(Console.ReadLine());
            Console.WriteLine(humidity);
        }
        public void ChangeTemp()
        {
            Console.WriteLine("Anna uusi lampotila: ");
            temperature = float.Parse(Console.ReadLine());
            Console.WriteLine("Temperature of the kiuas is " + temperature + "C");
        }

    }


}