namespace SubstringFinder.ConsoleClient
{
    using SubstringFinder.ConsoleClient.ServiceReference1;
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Description;

    public class ConsoleClient
    {
        private const string HostUrl = "http://localhost:8733/Design_Time_Addresses/SubstringFinder.Services/Service1/";

        internal static void Main()
        {
            try
            {
                using (var selfHost = HostSubstringFinderService())
                {
                    selfHost.Open();

                    var client = new SubstringFinderClient();
                    string text = "Create aWebservice library which accepts two string as parameters. It should return the number of times the second string contains the first string. Test it with the integrated WCF client.";
                    string substr = "string";
                    int count = client.GetSubstringCount(text, substr);
                    Console.WriteLine("Text: {0}", text);
                    Console.WriteLine("Substr: {0}", substr);
                    Console.WriteLine("Count: {0}", count);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static ServiceHost HostSubstringFinderService()
        {
            var serviceAddress = new Uri(HostUrl);
            var smb = new ServiceMetadataBehavior()
            {
                HttpGetEnabled = true
            };
            var selfHost = new ServiceHost(typeof(SubstringFinder.Services.SubstringFinder), serviceAddress);
            selfHost.Description.Behaviors.Add(smb);
            return selfHost;
        }
    }
}