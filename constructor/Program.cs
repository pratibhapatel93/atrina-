using System ;
namespace constructor 
{
    class Test
    {
        int marks ;
        static int maxmarks = 100;
        Test() //if no value is assigned then by default value is 0
        {this.marks= 70 ;}

        /*parameterised c,tor*/

        Test( int marks) 
        {
             this.marks= marks;
        }
        /*copy c'tor */
         Test( Test t) 
        {
             this.marks= t.marks;
        }
        
        void CalculatePercent()
        {
            int percent =this.marks*100/ Test.maxmarks;
            Console.WriteLine(percent);
        }
         
         static void Main(string[] args)
         {
            Test t1 = new Test();
            t1.CalculatePercent();
            Test t2=new Test(35);
            t2.CalculatePercent();
            Test t3=new Test(t2);
            t3.CalculatePercent();
            
         }
    }
}

