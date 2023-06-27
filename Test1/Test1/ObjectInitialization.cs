using System;


namespace Test1
{
    class ObjectInitialization
    {     
        /*
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the marks between 0 to 100:");
            int marks = Convert.ToInt32(Console.ReadLine());
            bool result = CheckTotalMarks(marks);

            if (marks > 0 && marks < 100)
            {
                 
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("please enter a number between 0 and 100.");
            }

          */ 
            
        }

        public static bool CheckTotalMarks(int marks)
        {
            return marks >= 40;
        }
    }

}