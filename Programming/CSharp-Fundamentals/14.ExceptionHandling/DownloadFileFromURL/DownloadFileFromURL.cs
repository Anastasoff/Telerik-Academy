/*
4. Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
and stores it the current directory. 
Find in Google how to download files in C#. 
Be sure to catch all exceptions and to free any used resources in the finally block.
*/

using System;
using System.Net;

class DownloadFileFromURL
{
    static void Main()
    {
        Console.Write("Enter URL (e.g. http://...): ");
        string url = Console.ReadLine(); // http://academy.telerik.com/images/default-album/telerik-academy-banner.jpg
        Console.Write("Enter file name (e.g. file.jpg): ");
        string fileName = Console.ReadLine();
        string filePath = @"..\..\" + fileName;

        using (WebClient Client = new WebClient())
        {
            try
            {
                Client.DownloadFile(url, filePath);
                Console.WriteLine("Download complete");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception cought!");
                Console.WriteLine(exception.GetType().Name);
                Console.WriteLine(exception.Message);
            }
        }
    }
}
