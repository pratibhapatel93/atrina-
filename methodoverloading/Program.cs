
using System;

public class Program
{
    public static void Main()
    { Program.Add(5,3);
    
    }
    public static void Add(int FN, int SN)
    {
        Console.WriteLine("Sum = {0}", FN + SN);
    }

    public static void Add(float FN, float SN)
    {
        Console.WriteLine("Sum = {1}", FN + SN);
    }

    public static void Add(int FN, float SN)
    {
        Console.WriteLine("Sum = {2}", FN + SN);
    }
}