
using System;
namespace methodhiding
 {

public class Employee
{
    public string FirstName;
    public string LastName;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class PartTimeEmloyee : Employee
{
    public new void PrintFullName()
    {
        base.PrintFullName();
      //onsole.WriteLine(FirstName + " " + LastName + "- Constractor");

    }

}

public class FullTimeEmployee : Employee
{

}

public class Program
{
    public static void Main()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "FullTime";
        FTE.LastName = "Employee";
        FTE.PrintFullName();

        PartTimeEmloyee PTE = new PartTimeEmloyee();
        PTE.FirstName = "PartTIME";
        PTE.LastName = "Employee";
        ((Employee)PTE).PrintFullName();



    }
}
}