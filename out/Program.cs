using System;

class Program
{
    public static void Main()
    {
        int Total = 0;
        int Product = 0;
        Calculate(10 ,20, out Total, out Product)
        
    }

    public static void Calculate(int FN ,int SN , out int Total , out int Product)
    {
        Total = FN + SN ;
        Product = FN * SN ;
    }
}