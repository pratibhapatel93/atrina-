using System;
using System.Text;

namespace Test1
{

    class Concatenate
    {
        /*
        public static void Main()
        {
            Console.WriteLine("Enter the first string:");
            string S1 = Console.ReadLine();

            Console.WriteLine("Enter the second string:");
            string S2 = Console.ReadLine();

            string concatenatedString = ConcatenateStrings(S1, S2);
            Console.WriteLine("Concatenated string: " + concatenatedString);
        }
        */

        public static string ConcatenateStrings(string S1, string S2)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(S1);
            sb.Append(S2);
            return sb.ToString();
        }
    }




}

