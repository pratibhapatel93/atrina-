using System;

class Customer 
{
    string _firstName;
    string _lastName;

    public Customer(string FirstName , string LastName)
    {
        this._firstName=FirstName;
        this._lastName=LastName;
    }

    public void PrintFullName()
    {
        Console.WriteLine("Full Name = {0}", _firstName +" "+ _lastName);
    }

    ~Customer()
    {
        //clean up code
    }
}

class Program
{
    public static void Main()
   { Customer C1=new Customer("Atrina" , "Technologies");
    C1.PrintFullName();
   }
}
