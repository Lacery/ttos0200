using System;



namespace olio_ja_repository
{
    class t1
    {
        public static void T1()
        {
            Hissi yksi = new Hissi();

            int muuttuja;
            Console.WriteLine("Anna kerros");
            muuttuja = int.Parse(Console.ReadLine());
            yksi.SwitchFloor(muuttuja);
            yksi.PrintFloor();

        }
    }


    class Hissi
    {

        //Fields
        private readonly int MaxKerros = 5;
        private readonly int MinKerros = 1;

        //Properties
        private int kerros;
        public int Kerros
        {
            get
            {
                return kerros;
            }
            set
            {

                if (value <= MaxKerros && value >= MinKerros) { kerros = value; }
                else { Console.WriteLine("Virheellinen kerros"); kerros = MinKerros; }
            }
        }



        //Constructors
        public Hissi()
        {
        }




        //Methods
        public void PrintFloor()
        {
            Console.WriteLine("Tamanhetkinen kerros on " + kerros);
        }
        public void SwitchFloor(int kerros)
        {
            Kerros = kerros;
            Console.WriteLine("Mennaan kerrokseen " + Kerros);
        }


    }


}