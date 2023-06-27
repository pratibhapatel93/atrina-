using System;
namespace ABSTRACT 
{
  public abstract class Customer //abstract class can inherit from an abstract class or an interface 
 {
    int ID;
    public abstract void Print();
  }

 public interface Customers //interface memebers cannot have access modifiers
 {
    void Print();
 }


 public class Program : Customer
{

    public override void Print()
    {
        Console.WriteLine("Print Method");
    } 
    public static void Main()
    {
        Customer C = new Program();
        C.Print();

    }
 }

}
