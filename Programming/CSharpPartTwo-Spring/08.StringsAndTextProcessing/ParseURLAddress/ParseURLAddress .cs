/*
12. Write a program that parses an URL address given in the format:
[protocol]://[server]/[resource]
and extracts from it the [protocol], [server] and [resource] elements. 
For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
[protocol] = "http"
[server] = "www.devbg.org"
[resource] = "/forum/index.php"
*/

using System;

internal class ParseURLAddress
{
    private static string ExtractResource(string fullAddress, string server)
    {
        string resource = string.Empty;
        char slash = '/';
        string symbols = "://";
        int symbolsIndex = fullAddress.IndexOf(symbols);
        int slashIndex = fullAddress.IndexOf(slash, symbolsIndex + symbols.Length);
        if (slashIndex != -1)
        {
            resource = fullAddress.Substring(slashIndex);
        }

        return resource;
    }

    private static string ExtractServer(string fullAddress, string protocol)
    {
        string server = string.Empty;
        char slash = '/';
        string symbols = "://";
        int protocolLength = 0;
        if (protocol.Length > 0)
        {
            protocolLength = protocol.Length + symbols.Length;
        }

        int slashIndex = fullAddress.IndexOf(slash, protocolLength);
        if (slashIndex != -1)
        {
            server = fullAddress.Substring(protocolLength, slashIndex - protocolLength);
        }

        return server;
    }

    private static string ExtractProtocol(string fullAddress)
    {
        string protocol = string.Empty;
        char colonChar = ':';
        int colonIndex = fullAddress.IndexOf(colonChar);
        if (colonIndex != -1)
        {
            protocol = fullAddress.Substring(0, colonIndex);
        }

        return protocol;
    }

    private static void Main()
    {
        Console.Write("Enter an URL: ");
        //// https://academy.telerik.com/about/telerik-academy.aspx
        string fullAddress = Console.ReadLine();

        string protocol = ExtractProtocol(fullAddress);
        Console.WriteLine("[protocol] = \"{0}\"", protocol);

        string server = ExtractServer(fullAddress, protocol);
        Console.WriteLine("[server] = \"{0}\"", server);

        string resource = ExtractResource(fullAddress, server);
        Console.WriteLine("[resource] = \"{0}\"", resource);
    }
}
