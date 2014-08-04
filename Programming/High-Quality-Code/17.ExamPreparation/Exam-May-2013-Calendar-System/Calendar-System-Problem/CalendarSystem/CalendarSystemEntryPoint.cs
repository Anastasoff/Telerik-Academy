namespace CalendarSystem
{
    using System;

    public class CalendarSystemEntryPoint
    {
        public static void Main()
        {
            var em = new EM();
            var proc = new Niki(em);

            while (true)
            {
                string ct = Console.ReadLine();
                if (ct == "End" || ct == null)
                {
                    break;
                }

                try
                {
                    // The sequence of commands is finished
                    Console.WriteLine(proc.ProcessCommand(Command.Parse(ct)));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}