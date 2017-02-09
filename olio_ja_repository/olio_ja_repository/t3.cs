using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace olio_ja_repository
{

    public class t3
    {
        public static void T3()
        {

            Corporation yhtio1 = new Corporation(); //Passitetaan worker1 Corporationille
            /*
            yhtio1.AddWorker("Pekka");
            yhtio1.AddWorker("Matti");
            yhtio1.AddWorker("Juha");
            yhtio1.PrintEmployees();
            yhtio1.FireWorker("Pekka");
            yhtio1.PrintEmployees();
            */

            int choice = 1;
            while (choice != 0)
            {
                Console.WriteLine("1. Palkkaa 2. Erota 3. Listaa 0. Lopeta");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Anna lisattavan henkilon nimi: ");
                        string lisattava = Console.ReadLine();
                        yhtio1.AddWorker(lisattava);
                        break;
                    case 2:
                        Console.WriteLine("Anna erotettavan henkilon nimi: ");
                        string erotettava = Console.ReadLine();
                        yhtio1.FireWorker(erotettava);
                        break;
                    case 3:
                        yhtio1.PrintEmployees();
                        break;
                    case 0:
                        break;
                }
            }

        }
    }

    public class Employee
    {
        public string Name;
        
        public Employee (string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
        
    };


    public class Corporation
    {
        private Employee _employee;
        List<Employee> workers = new List<Employee>();

        public Corporation() //Default constructor
        {
        }

        public Corporation(Employee employee) //Constructor
        {
            _employee = employee;
        }

        ~Corporation() //Destructor
        {
            //Console.WriteLine("Corporation is deleted");
        }


        public void AddWorker(string name)
        {
            workers.Add(new Employee(name));
        }

        public void FireWorker(string name)
        {
            for (int i = workers.Count -1; i >= 0; i--) //Iteroidaan lista väärinpäin jotta voidaan poistaa listasta
            {
                if (workers[i].Name == name) //Jos nimi löytyy listalta...
                {
                    Console.WriteLine(workers[i].Name + " is fired");
                    workers.RemoveAt(i); //...poistetaan se sieltä
                }
            }
        }

        public void PrintEmployees() //Tulostaa tyontekijat
        {
            foreach (Employee worker in workers)
            {
                Console.Write(worker.ToString() + " ");
            }
            Console.WriteLine(); //Rivinvaihto loppuun
        }

    };

}
