using System;


namespace Test1
{
    using System;

    class Program
    {
        /*
        public static void Main()
        {
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum= Calculations.Add(num1, num2);
            Console.WriteLine("Sum: " + sum);
            int difference = Calculations.Subtract(num1, num2);
            Console.WriteLine("Difference: " + difference);
            double average = Calculations.Average(num1, num2);
            Console.WriteLine("Average: " + average);
            
        }
        */
    }
        class Calculations
        {
        public static int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

       public static int Subtract(int num1, int num2)
        {
            int difference = num1 - num2;
            return difference;
        }

       public static double Average(int num1, int num2)
        {
            double average = (num1 + num2) / 2.0;
            return average;
        }
       
    }
}

        


