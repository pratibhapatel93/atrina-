using System;
 public class ExceptionHandlingAbuse
 {
    public static void Main()
    {   
        try
        {
        Console.WriteLine("please enter a numerator");
        int numerator;
        bool IsNumeratorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out numerator);

        if (IsNumeratorConversionSuccessful)
        {
             Console.WriteLine("please enter a denominator");
             int denominator;
             bool IsDenominatorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out denominator);
            
            if(IsDenominatorConversionSuccessful && denominator != 0)
            {
                int result = numerator/denominator ;
                Console.WriteLine("Result = {0}" , result) ;
            }
        
            else 
            {
                if (denominator == 0)
                {
                    Console.WriteLine("denominator cannot be zero");
                }
                else
                {
                    Console.WriteLine("denominator should be a valid number between {0} && {1}" , Int32.MinValue , Int32.MaxValue) ;
                }
            }
        }
            else 
            {
                Console.WriteLine("numerator shoud be valid number betweeen {0} && {1}" , Int32.MinValue , Int32.MaxValue);
            }
         }
         catch(Exception ex)
         {
            Console.WriteLine(ex.Message) ;
         }

    }
    
 }

