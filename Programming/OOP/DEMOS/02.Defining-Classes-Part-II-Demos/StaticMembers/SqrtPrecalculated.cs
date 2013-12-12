using System;

static class SqrtPrecalculated
{
    public const int MAX_VALUE = 10000;

    // Static field
    private static int[] sqrtValues;

    // Static constructor 
    static SqrtPrecalculated()
    {
        sqrtValues = new int[MAX_VALUE + 1];
        for (int i = 0; i < sqrtValues.Length; i++)
        {
            sqrtValues[i] = (int)Math.Sqrt(i);
        }
    }

    // Static method 
    public static int GetSqrt(int value)
    {
        return sqrtValues[value];
    }

    public static int Sqrt200
    {
        get { return sqrtValues[200]; }
    }
    // The Main() method is always static
    static void Main()
    {
        Console.WriteLine(GetSqrt(1000));
        Console.WriteLine(SqrtPrecalculated.Sqrt200);
    }
}
