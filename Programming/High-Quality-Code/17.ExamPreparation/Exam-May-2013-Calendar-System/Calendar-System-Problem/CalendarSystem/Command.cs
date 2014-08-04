namespace CalendarSystem
{
    using Contracts;
    public class Command : ICommand
    {
        private string name;
        private string[] arguments;

        public Command(string name, string[] arguments)
        {
            this.Name = name;
            this.Arguments = arguments;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                // TODO: validation
                this.name = value;
            }
        }

        public string[] Arguments
        {
            get
            {
                return this.arguments;
            }

            set
            {
                // TODO: validation
                this.arguments = value;
            }
        }
    }
}