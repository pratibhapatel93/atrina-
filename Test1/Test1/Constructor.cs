using System;


namespace Test1
{
    class Test
    {
        int marks;
        static int maxmarks = 100;
        Test() //if no value is assigned then by default value is 0
        {
            Console.WriteLine("parameterless");
            this.marks = 70; 
        }

        /*parameterised c,tor*/
        Test(int marks)
        {
            Console.WriteLine("parameterised");
            this.marks = marks;
        }
        void CalculatePercent()
        {
            int percent = this.marks * 100 / Test.maxmarks;
            Console.WriteLine(percent);
        }



        
       /*  public static void Main(string[] args)
        {
            Test t1 = new Test();
            t1.CalculatePercent();
            Test t2 = new Test(35);
            t2.CalculatePercent();

        }
       */
        
    }
}
