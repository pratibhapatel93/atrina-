
using System;
using System.IO;
namespace exceptionhandling

{class ExceptionHandling
{
    public static void Main()
    {
        StreamReader streamReader = null ;
        try
        {
         streamReader = new StreamReader(@"D:\test\Samplefiles\Data.txt");
        Console.WriteLine(streamReader.ReadToEnd());
        }
    
    catch(FileNotFoundException ex)
    {
        Console.WriteLine("please check if the file{0} exists", ex.FileName);
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
    if(streamReader != null)
    {
        streamReader.Close();
    }
    Console.WriteLine("Finally Block ");
    
    }
    }
}
}
