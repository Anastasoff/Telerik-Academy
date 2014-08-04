﻿namespace CalendarSystem
{
    using System;

    public struct Command
    {
        public string CommandName { get; set; }

        public string[] Paramms { get; set; }

        public static Command Parse(string c)
        {
            int j = c.IndexOf(' ');
            if (j == -1)
            {
                throw new Exception("Invalid command: " + c);
            }

            string nam = c.Substring(0, j);
            string arg = c.Substring(j + 1);

            var commandArguments = arg.Split('|');
            for (int i = 0; i < commandArguments.Length; i++)
            {
                arg = commandArguments[i];
                commandArguments[i] = arg.Trim();
            }

            var command = new Command { CommandName = nam, Paramms = commandArguments };

            return command;
        }
    }
}