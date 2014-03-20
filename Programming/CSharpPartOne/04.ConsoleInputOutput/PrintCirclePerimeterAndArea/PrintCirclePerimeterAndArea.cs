using System;

// 2. Write a program that reads the radius r of a circle and prints its perimeter and area.
class PrintCirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter circle's radius: ");
        double radius = double.Parse(Console.ReadLine());

        double diameter = 2 * radius;
        double perimeter = Math.PI * diameter;
        double area = Math.PI * (radius * radius);

        Console.WriteLine("Circle's perimeter is: {0:0.00}", perimeter);
        Console.WriteLine("Circle's area is: {0:0.00}", area);
    }
}
