using System;

class NumPattern
{
    public static void Main()
    {
        int n = 3;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }


        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}


