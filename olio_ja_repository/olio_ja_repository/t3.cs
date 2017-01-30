using System;



namespace olio_ja_repository
{
    class t3
    {
        public static void T3()
        {
            Boss pomo = new Boss("Pekka", "Johtaja", 50000, "Opel", 40000);
            Employee mortti = new Employee("Esa", "Maan matonen", 300);
            Employee toinen = new Employee("Kake", "Homppe", 5000);



            mortti.PrintInfo();
            mortti.ChangeName("Juho");
            mortti.PrintInfo();
            pomo.PrintInfo();
            pomo.ChangeSalary(13000);
            pomo.ChangeName("Pete");
            pomo.ChangeCar("Lada");
            pomo.PrintInfo();
            toinen.PrintInfo();

        }
    }


    class Employee
    {

        //Fields



        //Properties
        public string Name;
        public string Job;
        public int Salary;


        //Constructors
        public Employee(string name, string job, int salary)
        {
            Name = name;
            Job = job;
            Salary = salary;
        }



        //Methods

        public void PrintInfo()
        {
            Console.WriteLine("Nimi: " + Name + "\nAmmattinimike: " + Job + "\nPalkka: " + Salary + "\n");
        }

        public void ChangeName(string nimi)
        {
            Name = nimi;
        }
        public void ChangeJob(string job)
        {
            Job = job;
        }
        public void ChangeSalary(int salary)
        {
            Salary = salary;
        }

    }

    class Boss
    {



        //Fields



        //Properties
        public string Name;
        public string Job;
        public int Salary;
        public string Car;
        public int Bonus;

        //Constructors
        public Boss(string name, string job, int salary, string car, int bonus)
        {
            Name = name;
            Job = job;
            Salary = salary;
            Car = car;
            Bonus = bonus;
        }

        //Methods

        public void PrintInfo()
        {
            Console.WriteLine("Nimi: " + Name + "\nAmmattinimike: " + Job + "\nPalkka: " + Salary + "\nAuto : " + Car + "\nBonus: " + Bonus + "\n");
        }
        public void ChangeName(string nimi)
        {
            Name = nimi;
        }
        public void ChangeJob(string job)
        {
            Job = job;
        }
        public void ChangeSalary(int salary)
        {
            Salary = salary;
        }
        public void ChangeCar(string car)
        {
            Car = car;
        }
        public void ChangeBonus(int bonus)
        {
            Bonus = bonus;
        }

    }


}