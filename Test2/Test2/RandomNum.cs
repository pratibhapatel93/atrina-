using  System;

class RandomNum
{
    /*
    public static void Main(string[] args)
    {
        int Number = TwoDigitRandomNumber();
        Console.WriteLine("Random Number: " + Number);
        if (Number > 20)
        {
            Console.WriteLine("WIN");
        }
        else
        {
            Console.WriteLine("LOSE");
        }
    }
    */

    public static int TwoDigitRandomNumber()
    {
        Random random = new Random();
        int Number = random.Next(10, 100); 
        return Number;
        
    }
}


