using System;

// 10. Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
class CalculateSumWithAccuracy
{
    static void Main()
    {
        double sum = 1.0;

        for (double i = 2; 1 / i >= 0.001; i++)
        {
            if (i % 2 == 0)
            {
                sum += 1 / i;
            }
            else
            {
                sum -= 1 / i;
            }
        }

        Console.WriteLine("Sum = {0:F3}", sum); 
    }
}
