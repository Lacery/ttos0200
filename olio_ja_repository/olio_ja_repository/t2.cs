using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace Hello_Word
{
    class t2
    {
        public static void T2()
        {
            Pesukone samsung = new Pesukone("Samsung", 1972);

            samsung.StateModel();
            samsung.DryWash();

        }
    }


    class Pesukone
    {

        //Fields


        //Properties
        public string Model = "Model has not been set";
        public int Yearmodel;
        public bool State;
        public float Wash_time;
        public float Temperature;


        //Constructors
        public Pesukone()
        {
        }

        public Pesukone(string model)
        {
            Model = model;
        }

        public Pesukone(int yearmodel)
        {
            Yearmodel = yearmodel;
        }

        public Pesukone(string model, int yearmodel)
        {
            Model = model;
            Yearmodel = yearmodel;
        }


        //Methods
        public void StateModel()
        {
            Console.WriteLine("The model is " + Yearmodel + " " + Model);
        }
        public void DryWash()
        {
            Temperature = 60;
            Wash_time = 80;
            Console.WriteLine("Temperature is " + Temperature + "\nWash time is " + Wash_time);
        }
        public void NormalWash()
        {
            Temperature = 40;
            Wash_time = 50;
            Console.WriteLine("Temperature is " + Temperature + "\nWash time is " + Wash_time);
        }
        public void Power_on()
        {
            State = true;
            Console.WriteLine("The state of the machine is " + State);
        }
        public void Power_off()
        {
            State = false;
            Console.WriteLine("The state of the machine is " + State);
        }

    }


}