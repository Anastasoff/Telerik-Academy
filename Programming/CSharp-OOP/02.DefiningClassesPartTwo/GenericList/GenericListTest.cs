namespace GenericList
{
    using System;

    public class GenericListTest
    {
        public static void Main()
        {
            GenericList<int> testList = new GenericList<int>(2);

            for (int i = -5; i <= 5; i++)
            {
                testList.Add(i);
            }

            Console.WriteLine("Add: " + testList.ToString());

            Console.WriteLine("Get: " + testList.Get(3));

            testList.RemoveAt(3);
            Console.WriteLine("RemoveAt: " + testList);

            testList.InsertAt(3, -999);
            Console.WriteLine("InsertAt: " + testList);

            Console.WriteLine("Find: " + testList.Find(-999));

            Console.WriteLine("Min: " + testList.Min());

            Console.WriteLine("Max: " + testList.Max());

            testList.Clear();
            Console.WriteLine("Clear: " + testList ?? "[null]");
        }
    }
}