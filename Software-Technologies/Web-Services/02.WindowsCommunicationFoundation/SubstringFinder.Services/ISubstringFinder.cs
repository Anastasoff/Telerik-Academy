namespace SubstringFinder.Services
{
    using System.ServiceModel;

    [ServiceContract]
    public interface ISubstringFinder
    {
        [OperationContract]
        int GetSubstringCount(string text, string substr);
    }
}