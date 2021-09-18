using System;
using System.Collections;


namespace company
{
    class employee
    {
        int id, salary;
        string name;

        public int Id { set { id = value; } get { return id; } }
        public int Salary { set { salary = value; } get { return salary; } }
        public string Name { set { name = value; } get { return name; } }

        public void Print()
        {
            System.Console.WriteLine($"{Name} with id {Id} has salary {Salary} pounds");
        }
    }
    class sortByID : IComparer
    {
        public int Compare(object x, object y)
        {
            employee e1 = (employee)x;
            employee e2 = (employee)y;
            return e1.Id.CompareTo(e2.Id);
        }
    }


    class sortBySalary : IComparer
    {
        public int Compare(object x, object y)
        {
            employee e1 = (employee)x;
            employee e2 = (employee)y;
            return e1.Salary.CompareTo(e2.Salary);
        }
    }

    class sortByName : IComparer
    {
        public int Compare(object x, object y)
        {
            employee e1 = (employee)x;
            employee e2 = (employee)y;
            return e1.Name.CompareTo(e2.Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            employee[] emp = new employee[]
            {
                new employee{Id = 1 , Salary = 5000 , Name = "Ali"},
                new employee{Id = 2 , Salary = 4000 , Name = "Emad"},
                new employee{Id = 3 , Salary = 3000 , Name = "Zeyad"},
                new employee{Id = 4 , Salary = 2000 , Name = "Omar"},
                new employee{Id = 5 , Salary = 1000 , Name = "Hassan"},
            };
            IComparer cmpId = new sortByID();
            Array.Sort(emp, cmpId);
            System.Console.WriteLine("Sorting employess with id: ");
            foreach (employee e in emp)
            {
                e.Print();
            }
            System.Console.WriteLine();



            IComparer cmpSalary = new sortBySalary();
            Array.Sort(emp, cmpSalary);
            System.Console.WriteLine("Sorting employess with salary: ");
            foreach (employee e in emp)
            {
                e.Print();
            }
            System.Console.WriteLine();


            IComparer cmpName = new sortByName();
            Array.Sort(emp, cmpName);
            System.Console.WriteLine("Sorting employess with name: ");
            foreach (employee e in emp)
            {
                e.Print();
            }
            System.Console.WriteLine();
        }
    }
}
