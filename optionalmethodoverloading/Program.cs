using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace optionalmethodoverloading
{

class Program
{
    public static void Main()
    {
      Sum(10,20,new int[]{30 ,40});
    }

    public static void Sum(int firstnumber , int secondnumber ) // overloaded sum method to make parameter optional 
    {
      Sum( firstnumber ,secondnumber , null );
    }
    public static void Sum(int firstnumber , int secondnumber , int[] restOfNumbers)
    {
        int result = firstnumber + secondnumber;
        if(restOfNumbers != null)
        {
            foreach(int i in restOfNumbers)
            {
                result += i ;
            
            }
        }
        Console.WriteLine(" Total="+ result);
    }
}
}
