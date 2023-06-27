using System ;
namespace Training 
{
    public class Mainclass
    {
        private static void Main()
        {
            //Customer C1 = new Customer();
            Customer C1= null ;

           //string str = C1.ToString(); //-throws null reference exception 
            // handles null and return empty striing
             string str = Convert.ToString(C1);

            Console.WriteLine(str);

        }
    }

    public class Customer 
    {
      public string Name {get; set;}
    }
}