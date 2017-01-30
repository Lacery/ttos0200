using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olio_ja_repository
{
    class t5
    {
        public static void T5()
        {

            //ON/OFF, Volume0-9, Frequency2000.0-26000.0
            Radio radio = new Radio(1, 20550.5, false);
            radio.PrintInfo();
            radio.SwitchPower();
        }
    }

    class Radio
    {

        private readonly int MaxVolume = 9;
        private readonly int MinVolume = 0;

        private readonly double MaxFreq = 26000.0;
        private readonly double MinFreq = 2000.0;

        private int volume;
        private double freq;

        public int Volume {
            get { return MinVolume; }

            set {
                if (value > MaxVolume || value < MinVolume) { Console.WriteLine("Invalid volume. Set to " + MinVolume); volume = MinVolume; }
                else { volume = value;  }
                }
        }

        public double Freq {
            get { return MinFreq; }
            set
            {
                if (value > MaxFreq || value < MinFreq) { Console.WriteLine("Invalid frequency. Set to " + MinFreq); freq = MinFreq; }
                else { freq = value;  }
            }
        }

        public static bool Power { get; set; }


        public Radio(int volume, double freq, bool power)
        {
            Volume = volume;
            Freq = freq;
            Power = power;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Frequency is " + freq);
            Console.WriteLine("Volume is " + volume);
        }
        public void SwitchPower()
        {
            if (Power == true) { Console.WriteLine("Power is on"); }
            else { Console.WriteLine("Power is off"); }
        }

    }
}
