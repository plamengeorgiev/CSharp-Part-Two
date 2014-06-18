//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
//reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
//Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;
using System.Security;

class ReadingAFile  //the comments are unnecessary
{
    static void Main()
    {
        Console.WriteLine("Please enter the file name along with the full file path: ");
        string filePath = Console.ReadLine();
        try
        {
            Console.WriteLine(System.IO.File.ReadAllText(filePath));
        }
        catch (ArgumentNullException ane)
        {
            Console.WriteLine(ane.Message);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (PathTooLongException ptl)
        {
            Console.WriteLine(ptl.Message);
        }
        catch (DirectoryNotFoundException dnf)
        {
            Console.WriteLine(dnf.Message);
        }
        catch (UnauthorizedAccessException uae)
        {
            Console.WriteLine(uae.Message);
        }
        catch (FileNotFoundException fnf)
        {
            Console.WriteLine(fnf.Message);
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
        catch (NotSupportedException nse)
        {
            Console.WriteLine(nse.Message);
        }
        catch (SecurityException se)
        {
            Console.WriteLine(se.Message);
        }
    }
}
