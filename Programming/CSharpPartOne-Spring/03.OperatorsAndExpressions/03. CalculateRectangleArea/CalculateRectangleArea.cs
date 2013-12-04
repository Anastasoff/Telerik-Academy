// 3. Write an expression that calculates rectangle’s area by given width and height.

using System;

class CalculateRectangleArea
{
    static void Main()
    {
        Console.Write("Enter widht: ");
        double wight = double.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine());
        double area = wight * height;
        Console.WriteLine("Rectangle area is: " + area);
    }
}
