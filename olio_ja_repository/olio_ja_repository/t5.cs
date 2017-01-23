
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace olio_ja_repository
{

    public class t5
    {
        //Fields
        private static int Age;
        private static string Name;
        private static string Study;
        private static bool Employed;
        private static string[] Student = new string[4];


        //Properties


        //Constructors
        public t5(int age, string name, string study, bool employed)
        {
            Student[0] = Convert.ToString(age);
            Student[1] = name;
            Student[2] = study;
            Student[3] = Convert.ToString(employed);

        }


        //Methods
        public static void PrintInfo()
        {
            foreach (var item in Student){
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //Console.WriteLine(Age +"\n" + Name + "\n" + Study + "\n" + Employed);

        }


    }
}


