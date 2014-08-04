namespace CalendarSystem
{
    using System;
    using Contracts;

    public class ProgramEntryPoint
    {
        public static void Main()
        {
            var newEventManager = new EventManager();
            var processor = new Niki(newEventManager);

            while (true)
            {
                string inputCommand = Console.ReadLine();
                if (inputCommand == "End" || inputCommand == null)
                {
                    break;
                }

                try
                {
                    // The sequence of commands is finished
                    ICommandParser newCommand = new CommandParser(inputCommand);
                    Command parsedCommand = newCommand.Parse();
                    string processedCommand = processor.ProcessCommand(parsedCommand);
                    Console.WriteLine(processedCommand);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}