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

            Persons personlist = new Persons();

            personlist.AddPerson("Ville", "Halminen", "160494-423C");
            personlist.AddPerson("Pekka", "Makela", "160494-134D");
            personlist.AddPerson("Jase", "Jupela", "160494-122F");

            personlist.GetPerson(2);
            personlist.FindPerson("160494-423C");
            personlist.PrintData();
        }
    }

    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string SocialSecurityNumber { get; set; }

        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + SocialSecurityNumber;
        }

    }


    class Persons : Person
    {
        //List-kokoelma yksittäisille henkilöille -> 
        List<Person> persons = new List<Person>();

        public void AddPerson(string firstname, string lastname, string ssn) //Metodi lisää uuden Person-persoonan persons-listaan
        {

            persons.Add(new Person { Firstname = firstname, Lastname = lastname, SocialSecurityNumber = ssn });

        }

        public void GetPerson(int i) //Etsii ja tulostaa persons-listasta henkilön jonka indeksi on i
        {
            Console.WriteLine(persons[i].ToString());
        }

        public void FindPerson(string hetu)
        {
            foreach (Person nimi in persons) //Käydään lista läpi
            {
                if (nimi.SocialSecurityNumber == hetu) //Jos SocialSecurityNumber on sama kuin kutsussa annettu hetu -> Tulosta etunimi ja sukunimi
                {
                    Console.WriteLine(nimi.Firstname + " " + nimi.Lastname);
                }
            }
        }

        public void PrintData() //Tulostaa kaikkien listan henkilöiden kaikki tiedot yläohjelman ToStringin mukaisesti
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString()); //Käyttää yliohjelma ToString-metodia
            }
        }


    }


}
