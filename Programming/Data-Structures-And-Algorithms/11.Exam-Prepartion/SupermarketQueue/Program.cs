namespace SupermarketQueue
{
    using System;
    using System.Text;
    using Wintellect.PowerCollections;

    public class Program
    {
        private const string AppendCmd = "Append";
        private const string InsertCmd = "Insert";
        private const string FindCmd = "Find";
        private const string ServeCmd = "Serve";
        private const string EndCmd = "End";

        private const string OkMsg = "OK";
        private const string ErrorMsg = "Error";

        private const int InitialQueueCapacity = short.MaxValue;

        private static BigList<string> queue;
        private static Bag<string> names;
        private static StringBuilder result;

        public static void Main()
        {
            queue = new BigList<string>();
            names = new Bag<string>();
            result = new StringBuilder();

            CommandProcessor();

            Console.Write(result);
        }

        private static void CommandProcessor()
        {
            while (true)
            {
                string commandLine = Console.ReadLine();
                // End
                if (commandLine == EndCmd)
                {
                    return;
                }

                int startIndex = 0;
                // Append
                if (commandLine.StartsWith(AppendCmd))
                {
                    startIndex = AppendCmd.Length + 1;
                    string name = commandLine.Substring(startIndex);

                    queue.Add(name);
                    names.Add(name);

                    result.AppendLine(OkMsg);
                }
                // Insert
                else if (commandLine.StartsWith(InsertCmd))
                {
                    startIndex = InsertCmd.Length + 1;
                    string[] positionAndName = commandLine.Substring(startIndex).Split(' ');
                    int position = int.Parse(positionAndName[0]);
                    string name = positionAndName[1];
                    if (position <= queue.Count)
                    {
                        queue.Insert(position, name);
                        names.Add(name);

                        result.AppendLine(OkMsg);
                    }
                    else
                    {
                        result.AppendLine(ErrorMsg);
                    }
                }
                // Find
                else if (commandLine.StartsWith(FindCmd))
                {
                    startIndex = FindCmd.Length + 1;
                    string name = commandLine.Substring(startIndex);
                    int found = names.NumberOfCopies(name);
                    result.AppendLine(found.ToString());
                }
                // Serve
                else if (commandLine.StartsWith(ServeCmd))
                {
                    startIndex = ServeCmd.Length + 1;
                    int count = int.Parse(commandLine.Substring(startIndex));

                    if (count <= queue.Count)
                    {
                        string[] served = new string[count];
                        for (int i = 0; i < count; i++)
                        {
                            served[i] = queue[i];
                        }

                        queue.RemoveRange(0, count);
                        names.RemoveMany(served);

                        string formated = string.Join(" ", served);
                        result.AppendLine(formated);
                    }
                    else
                    {
                        result.AppendLine(ErrorMsg);
                    }
                }
            }
        }
    }
}