
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace olio_ja_repository
{

    public class t5
    {
        //Fields
        public struct Student //Tietue johon tallennetaan: En pitänyt taulukosta
        {
            public static int Age;
            public static string Name;
            public static string Study;
            public static bool Employed;
        }


        //Properties


        //Constructors
        public t5()
        {

        }


        //Methods 
        public static void T5() //"Pääohjelma" jolla ajetaan luokan metodeja
        {
            t5 student = new t5();
            string[] tiedot = new string[4];
            Console.WriteLine("Anna oppilaan ika, nimi, opiskeluala ja tyottomyys/tyollisyys(true/false): ");
            for (int i = 0; i <= 3; i++)
            {
                tiedot[i] = Console.ReadLine();
            }
            student.SaveInfo(Convert.ToInt32(tiedot[0]), tiedot[1], tiedot[2], Convert.ToBoolean(tiedot[3]));

            student.PrintInfo();
        }

    public void SaveInfo(int age, string name, string study, bool employed)
        {
            Student.Age = age;
            Student.Name = name;
            Student.Study = study;
            Student.Employed = employed;

        }
       
        public void PrintEmployment()
        {
            Console.WriteLine(Student.Employed);
        }
        public void PrintName()
        {
            Console.WriteLine(Student.Name);
        }
        public void PrintInfo()
        {
            Console.WriteLine(Student.Age);
            Console.WriteLine(Student.Name);
            Console.WriteLine(Student.Study);
            Console.WriteLine(Student.Employed);
            Console.WriteLine();

        }


    }
}


