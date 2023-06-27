//making method parameters optional by specifying parametr defaults 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
namespace methodparameterdemo
{

class Program
{
    public static void Main()
    {
      //Sum(10,20,new int[]{20,30,40});
        Sum(10,20);
    }
    
    //public static void Sum(int firstnumber , int secondnumber , int[] restOfNumbers = null) //setting default parameter value
    public static void Sum(int firstnumber , int secondnumber , [Optional]int[] restOfNumbers ) //using optional attribute 
    {
        int result = firstnumber + secondnumber;
        if(restOfNumbers != null)
        {
            foreach(int i in restOfNumbers)
            {
                result += i ;
            
            }
        }
        Console.WriteLine(" Total="+ result.ToString());
    }
 }
}
