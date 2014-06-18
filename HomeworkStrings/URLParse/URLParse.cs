//Write a program that parses an URL address given in the format:
//and extracts from it the [protocol], [server] and [resource] elements. For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//[protocol] = "http"
//[server] = "www.devbg.org"
//[resource] = "/forum/index.php"

using System;
using System.Linq;

class URLParse
{
    static void Main()
    {
        Uri url = new Uri("http://www.devbg.org/forum/index.php");  //i'm using Uri 
        Console.WriteLine("[protocol] = \"{0}\"", url.Scheme);
        Console.WriteLine("[server] = \"{0}\"", url.Host);
        Console.WriteLine("[resourse] = \"{0}\"", url.AbsolutePath);
    }
}
