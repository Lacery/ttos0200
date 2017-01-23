using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace Hello_Word
{
    class t3
    {
        public static void T3()
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


    class Televisio
    {

        //Fields


        //Properties
        public string Model = "Model has not been set";
        public string Color;
        public double Size;
        public string Resolution;
        public bool State;
        public int Channel;
        public int Volume;



        //Constructors
        public Televisio()
        {
        }

        public Televisio(string model, string color, double size, string resolution)
        {
            Model = model;
            Color = color;
            Size = size;
            Resolution = resolution;
        }

        public Televisio(string model, int channel, int volume)
        {
            Model = model;
            Channel = channel;
            Volume = volume;
        }


        //Methods
        public void PrintInfo()
        {
            Console.WriteLine("Model: " + Model + "\nColor: " + Color + "\nSize: " + Size + "\"\nResolution: " + Resolution + "\nCurrent channel: " + Channel + "\nVolume: " + Volume);
        }
        public void SwitchOn()
        {
            State = true;
        }
        public void SwitchOff()
        {
            State = false;
        }
        public void SwitchChannel()
        {
            Console.WriteLine("Switch to which channel?");
            Channel = int.Parse(Console.ReadLine());
            Console.WriteLine("Channel is now " + Channel);
        }
        public void ChangeVolume(int volume)
        {
            Volume = volume;
            Console.WriteLine("Volume is now " + Volume);
        }


    }


}