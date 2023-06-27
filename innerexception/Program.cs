
using System;
using System.IO;
using System.Linq.Expressions;
using System.Security.Cryptography;

class InnerException
{
    public static void Main()
    {
        try { 
        try
        {
            Console.WriteLine("Enter First Number");
            int FN = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int SN = Convert.ToInt32(Console.ReadLine());

            int Result = FN / SN;

            Console.WriteLine("Result = {0}", Result);
        }
        catch (Exception ex)
        {
            string filePath = @"D:\test\Samplefiles\Log.txt";
            if (File.Exists(filePath))
            {
                StreamWriter sw = new StreamWriter(filePath);
                sw.WriteLine(ex.GetType().Name);
                sw.WriteLine();
                sw.Write(ex.Message);
                sw.Close();

                Console.WriteLine("There is a problem, Please try later");

            }
            else
            {
                throw new FileNotFoundException(filePath + "is not present", ex);
            }
        }
    }
    catch(Exception exception)
        {
         Console.WriteLine("Current Exception= {0}", exception.GetType().Name);
        }
 }
}