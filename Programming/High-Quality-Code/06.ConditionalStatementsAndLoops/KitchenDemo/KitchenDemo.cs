namespace KitchenDemo
{
    using System;

    using Kitchen;

    public class KitchenDemo
    {
        public static void Main()
        {
            Chef theDev = new Chef();
            theDev.MakeSoup();

            Console.WriteLine(theDev.Log);
        }
    }
}