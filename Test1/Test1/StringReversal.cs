using System;
using System.Text;

namespace Test1
{ 
class StringReversal
{
        /*
    public static void Main(string[] args)

    {
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();
            string result = ReversedString(inputString);
            Console.WriteLine(result);
        
    } 
        */

    public static string ReversedString(string inputString)
    {
        if (inputString.Length < 3 || inputString.Length > 10)
        {
            return "Input string must have a minimum of 3 characters and a maximum of 10 characters.";
        }

        StringBuilder ReversedString = new StringBuilder();
        int Size = inputString.Length;

        for (int i = Size - 1; i >= 0; i--)
        {
            ReversedString.Append(inputString[i]);
        }

        return $"New Reversed string: {ReversedString}\nCharacter count: {Size}";
    }
}

}
    
 










