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

            Persons Ville = new Persons();
            Persons Pekka = new olio_ja_repository.Persons();

            Pekka.AddPerson("Pekka", "Lahtinen", "12345134");
            Pekka.PrintData();

            Ville.AddPerson("Ville", "Halminen", "160494-1234");
            Ville.PrintData();


        }
    }

    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string SocialSecurityNumber { get; set; }
        
    }


    class Persons : Person
    {
        //List-kokoelma yksittäisille henkilöille -> 
        List<Person> persons = new List<Person>();

        public void AddPerson(string firstname, string lastname, string ssn) 
        {

            persons.Add(new Person { Firstname = firstname, Lastname = lastname, SocialSecurityNumber = ssn });

        }
        


    }


}
