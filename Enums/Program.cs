using System;
namespace Enums
{

public class Enums
{
    public static void Main()
    {
        int[] Values = (int[])Enum.GetValues(typeof(Gender));
        foreach (int value in Values)
        {
            Console.WriteLine(value);
        }
        string[] Names = Enum.GetNames(typeof(Gender));
        foreach(string Name in Names)
        {
            Console.WriteLine(Name);
        }

      
    }
}
public enum Gender
{
    unknown,
    male,
    female 
}
}