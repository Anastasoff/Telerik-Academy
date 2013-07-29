// 3. Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareCharArrays
{
    static void Main()
    {
        bool areTheSame = true;

        // input       

        // first char array
        Console.Write("Enter text: ");
        string firstStr = Console.ReadLine();
        char[] firstArr = firstStr.ToCharArray();

        Console.WriteLine(new string('-', 20));

        // second char array
        Console.Write("Enter text: ");
        string secondStr = Console.ReadLine();
        char[] secondArr = secondStr.ToCharArray();

        //// filling char arrays without any strings

        //// first array
        //Console.Write("Enter first array elements: ");
        //int firstArrSize = int.Parse(Console.ReadLine());
        //char[] firstArr = new char[firstArrSize];
        //for (int i = 0; i < firstArr.Length; i++)
        //{
        //    Console.Write("Enter char #{0}: ", i);
        //    firstArr[i] = char.Parse(Console.ReadLine());
        //}

        //Console.WriteLine(new string('-', 20));

        //// second array
        //Console.Write("Enter second array elements: ");
        //int secondArrSize = int.Parse(Console.ReadLine());
        //char[] secondArr = new char[secondArrSize];
        //for (int i = 0; i < secondArr.Length; i++)
        //{
        //    Console.Write("Enter char #{0}: ", i);
        //    secondArr[i] = char.Parse(Console.ReadLine());
        //}

        Console.WriteLine(new string('-', 20));

        // comparing and printing
        if (firstArr.Length != secondArr.Length)
        {
            Console.WriteLine("Arrays have different legth!");
        }
        else
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    Console.WriteLine("Element #{0} is different in one of the arrays", i);
                    areTheSame = false;
                    break;
                }
            }

            if (areTheSame == true)
            {
                Console.WriteLine("Arrays are the same!");
            }
        }
    }
}
