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
        public string Name { get; set; }
        public string Job { get; set; }
        public int Salary { get; set; }


        //Constructors
        public Employee(string name, string job, int salary)
        {
            Name = name;
            Job = job;
            Salary = salary;
        }



        //Methods

        public virtual void PrintInfo()
        {
            Console.WriteLine("Nimi: " + Name + "\nAmmattinimike: " + Job + "\nPalkka: " + Salary + "\n");
        }

        public virtual void ChangeName(string nimi)
        {
            Name = nimi;
        }
        public virtual void ChangeJob(string job)
        {
            Job = job;
        }
        public virtual void ChangeSalary(int salary)
        {
            Salary = salary;
        }

    }

    class Boss : Employee
    {



        //Fields



        //Properties
        public string Car { get; set; }
        public int Bonus { get; set; }

        //Constructors
        public Boss(string name, string job, int salary, string car, int bonus)
            : base(name,job, salary)
        {
            Car = car;
            Bonus = bonus;
        }

        //Methods

        public override void PrintInfo()
        {
            Console.WriteLine("Nimi: " + Name + "\nAmmattinimike: " + Job + "\nPalkka: " + Salary + "\nAuto : " + Car + "\nBonus: " + Bonus + "\n");
        }
        public override void ChangeName(string nimi)
        {
            Name = nimi;
        }
        public override void ChangeJob(string job)
        {
            Job = job;
        }
        public override void ChangeSalary(int salary)
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