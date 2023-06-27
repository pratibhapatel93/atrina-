using System ;
 namespace ifelse 
 {
    class Program
 {   
    static void Main()
    {
        Console.WriteLine("enter a number");
        int number = int .Parse(Console.ReadLine());

        switch (number)
        {
            /*case 10: 
                 Console.WriteLine("your number is 10");
                 break;
            case 20: 
                 Console.WriteLine("your number is 20");
                 break;
            case 30: 
                 Console.WriteLine("your number is 30");
                 break;          
             default: 
                 Console.WriteLine("your number is not 10,20,30");
                 break; */


               case 10:
               case 20:
               case 30:
                       Console.WriteLine("your number is {0} " , number);
                       break;
                default:
                       Console.WriteLine("your number is not 10 , 20 , 30");
                       break;       


        }
    }
}

}
