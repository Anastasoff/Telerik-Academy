namespace CalendarSystem.Contracts
{
    public interface ICommand
    {
        string Name { get; set; }

        string[] Arguments { get; set; }
    }
}