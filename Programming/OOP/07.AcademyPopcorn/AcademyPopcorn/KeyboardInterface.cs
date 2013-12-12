namespace AcademyPopcorn
{
    using System;

    public class KeyboardInterface : IUserInterface
    {
        public event EventHandler OnLeftPressed;

        public event EventHandler OnRightPressed;

        public event EventHandler OnActionPressed;

        public void ProcessInput()
        {
            for (int i = 0; i < 3; i++)
            {
                if (Console.KeyAvailable)
                {
                    var keyInfo = Console.ReadKey(true);

                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }

                    if (keyInfo.Key.Equals(ConsoleKey.A) || keyInfo.Key.Equals(ConsoleKey.LeftArrow))
                    {
                        if (this.OnLeftPressed != null)
                        {
                            this.OnLeftPressed(this, new EventArgs());
                        }
                    }

                    if (keyInfo.Key.Equals(ConsoleKey.D) || keyInfo.Key.Equals(ConsoleKey.RightArrow))
                    {
                        if (this.OnRightPressed != null)
                        {
                            this.OnRightPressed(this, new EventArgs());
                        }
                    }

                    if (keyInfo.Key.Equals(ConsoleKey.Spacebar))
                    {
                        if (this.OnActionPressed != null)
                        {
                            this.OnActionPressed(this, new EventArgs());
                        }
                    }
                }
            }
        }
    }
}
