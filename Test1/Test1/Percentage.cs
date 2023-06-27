using System;


namespace Test1
{
    class Percentage
    {
   /* 
        public static void Main()
    {
        Console.WriteLine("Enter the first decimal value:");
        decimal D1 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter the second decimal value:");
        decimal D2 = Convert.ToDecimal(Console.ReadLine());

        decimal percentage = Percent(D1, D2);
        Console.WriteLine(" Your assessment Percent is : " + percentage + "%");
    }
   */

    public static decimal Percent(decimal D1, decimal D2)
    {
        decimal percentage = (D1 - D2) / D2 * 100;
        return percentage;
    }
}
}
