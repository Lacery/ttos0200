using System;



namespace olio_ja_repository
{
    class t2
    {
        public static void T2()
        {
            Vahvistin yksi = new Vahvistin();

            int muuttuja;
            Console.WriteLine("Anna Voluumi");
            muuttuja = int.Parse(Console.ReadLine());
            yksi.SwitchVolume(muuttuja);
            yksi.PrintVolume();

        }
    }


    class Vahvistin
    {

        //Fields
        private readonly int MaxVolume = 100;
        private readonly int MinVolume = 0;

        //Properties
        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value > MaxVolume) { Console.WriteLine("Too high volume. Volume is set to " + MaxVolume); }
                if (value < MinVolume) { Console.WriteLine("Too low volume. Volume is set to " + MinVolume); }
                else { volume = value; }
            }
        }



        //Constructors
        public Vahvistin()
        {
        }




        //Methods
        public void PrintVolume()
        {
            if (volume < MaxVolume && volume > MinVolume)
            {
                Console.WriteLine("Volume is set to " + volume);
            }
            else
            {
                Console.WriteLine("Invalid volume");
            }
        }
        public void SwitchVolume(int kerros)
        {
            Volume = kerros;
        }


    }


}