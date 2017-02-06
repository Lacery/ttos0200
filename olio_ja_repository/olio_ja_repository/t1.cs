using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace olio_ja_repository
{

    public class t1
    {
        public static void T1()
        {
            Persons Ville = new Persons("Ville", 23, "160494-119M");

            //Fugfugfugfug
            Ville.AddPerson("Ville", 23, "1601431-123M");
            Console.WriteLine(Ville.PrintData());


        }
    }

    class Person
    {
        //Person-luokka yksittäisen henkilön tietojen ylläpitämiseen ja tulostamiseen
        public string Name { get; set; }
        public int Age { get; set; }
        public string HeTu { get; set; }

        public Person()
        {

        }

        public Person(string name, int age, string hetu)
        {
            Name = name;
            Age = age;
            HeTu = hetu;
        }



        public virtual string PrintData()
        {
            return "ss";
        }

    }


    class Persons : Person
    {
        //List-kokoelma yksittäisille henkilöille -> 
        public List<Person> Lista { get; set; }

        public Persons(string name, int age, string hetu):base(name,age,hetu)
        {
        }



        public void AddPerson(string name, int age, string hetu)
        {
            //Lisätään henkilö Listaan
            Lista.Add(new Person { Name = name, Age = age, HeTu = hetu });
        }

        public void GetPerson()
        {
            //Haetaan henkilö listan alkion indeksillä

        }

        public void FindPerson()
        {
            //Haetaan henkilö Listasta hetu:lla

        }


        public override string PrintData()
        {

            //Tulostetaan kaikki Listan henkilöt 

            return Lista[0].Name + " " + Lista[0].Age + " " + Lista[0].HeTu;

        }

    }


}
