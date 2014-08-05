namespace CalendarSystem
{
    using Contracts;
    using System;

    public class CommandParser : ICommandParser
    {
        private string inputCommand;

        public CommandParser(string inputCommand)
        {
            this.inputCommand = inputCommand;
        }

        public Command Parse()
        {
            int firstWhiteSpace = this.inputCommand.IndexOf(' ');
            if (firstWhiteSpace == -1)
            {
                throw new Exception("Invalid command: " + this.inputCommand);
            }

            string commandName = this.inputCommand.Substring(0, firstWhiteSpace);
            string argsAsString = this.inputCommand.Substring(firstWhiteSpace + 1);

            var commandArguments = argsAsString.Split('|');
            for (int i = 0; i < commandArguments.Length; i++)
            {
                string currentArgument = commandArguments[i];
                commandArguments[i] = currentArgument.Trim();
            }

            Command command = new Command(commandName, commandArguments);

            return command;
        }
    }
}