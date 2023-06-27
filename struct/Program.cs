using System;
namespace STRUCT
{
public struct Customer 
{
    private int _id;
    private string _name;

    public string Name
    { get {return _name;}
      set{_name = value;}
    }

    public int ID
    {
        get{return this._id;}
        set{this._id=value;}
    }

    public Customer(int Id ,string Name)
    {
      this._id = Id;
      this._name = Name;
    }
    public void PrintDetails()
    {
        Console.WriteLine("Id = {0} && Name = {1}" , this._id , this._name);
    }
}
public class Program
{
    public static void Main()
    {
        Customer C1 = new Customer(101 , "mac");
        C1.PrintDetails();

        Customer C2 = new Customer(); // using default ctor , and intitalizinge fields 
        C2.ID = 102;
        C2.Name = "john";
        C2.PrintDetails();

        
        // object intializer syntax
        Customer C3 = new Customer
        {
            ID = 103 ,
            Name = "mario"
        };
        C3.PrintDetails();


    }

}
}
