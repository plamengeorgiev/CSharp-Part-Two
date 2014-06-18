//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
//and stores it the current directory. Find in Google how to download files in C#. 
//Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

class InternetDownload      //the comments are unnecessary
{
    static void Main()
    {
        string address = "http://www.devbg.org/img/Logo-BASD.jpg";  
        string file = "logo.jpg";

        using (WebClient client = new WebClient())  
        {
            try
            {
                client.DownloadFile(address, file);
                Console.WriteLine("The file was successfuly downloaded");
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (WebException we)
            {
                Console.WriteLine(we.Message);
            }
            catch (NotSupportedException nse)
            {
                Console.WriteLine(nse.Message);
            }

        }
    }
}
