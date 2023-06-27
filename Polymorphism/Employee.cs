using System;

namespace Polymorphism
{
    public class Employee
    {
        public string FirstName = "pratibha";
        public string LastName = "patel";


        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class PartTimeEmployee : Employee
    {

    }

    public class FullTimeEmployee : Employee
    {

    }

    public class TemporaryEmployee : Employee
    {

    }




    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach(Employee e in employees)
            {
                e.PrintFullName();
            }
           



        }
    }
}