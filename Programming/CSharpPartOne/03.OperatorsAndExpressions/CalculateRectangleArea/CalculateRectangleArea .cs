using System;

// 3. Write an expression that calculates rectangle’s area by given width and height.
class CalculateRectangleArea 
{
    static void Main()
    {
        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine());
        Console.Write("Enter width: ");
        double width = double.Parse(Console.ReadLine());

        double result = height * width;
        Console.WriteLine("Rectangle’s area: {0}", result);
    }
}
