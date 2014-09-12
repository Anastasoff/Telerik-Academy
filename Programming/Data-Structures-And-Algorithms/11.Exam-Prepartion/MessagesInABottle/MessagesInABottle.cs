namespace MessagesInABottle
{
    using System;
    using System.Collections.Generic;

    public class MessagesInABottle
    {
        private static string secretMessage;
        private static List<Cipher<char, string>> ciphers = new List<Cipher<char, string>>();
        private static List<string> messages = new List<string>();

        public static void Main()
        {
            ProcessInput();

            GenerateMessages(0, string.Empty);

            PrintOutput();
        }

        private static void PrintOutput()
        {
            messages.Sort();
            Console.WriteLine(messages.Count);
            foreach (var msg in messages)
            {
                Console.WriteLine(msg);
            }
        }

        private static void ProcessInput()
        {
            secretMessage = Console.ReadLine();
            string inputCipher = Console.ReadLine();

            char key = char.MinValue;
            string value = string.Empty;
            for (int i = 0; i < inputCipher.Length; i++)
            {
                if (char.IsLetter(inputCipher[i]))
                {
                    if (i > 1)
                    {
                        var cipher = new Cipher<char, string>(key, value);
                        ciphers.Add(cipher);
                        value = string.Empty;
                    }

                    key = inputCipher[i];
                }
                else
                {
                    value += inputCipher[i];
                }
            }

            ciphers.Add(new Cipher<char, string>(key, value));
        }

        private static void GenerateMessages(int messagePointer, string msg)
        {
            if (messagePointer == secretMessage.Length)
            {
                messages.Add(msg);
                return;
            }

            foreach (var cipher in ciphers)
            {
                if (secretMessage.Substring(messagePointer).StartsWith(cipher.Value))
                {
                    GenerateMessages(messagePointer + cipher.Value.Length, msg + cipher.Key);
                }
            }
        }
    }
}