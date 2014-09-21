namespace DaysOfWeekConverter.Services
{
    using System;
    using System.ServiceModel;

    [ServiceContract]
    public interface IDaysOfWeekConverter
    {
        [OperationContract]
        string GetDayOfWeek(DateTime date);
    }
}