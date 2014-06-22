using System;

// 8. Declare two string variables and assign them with “Hello” and “World”. 
// Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). 
// Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

class Object
{
    static void Main()
    {
        string firstStrVar = "Hello";
        string secondStrVar = "World";
        object objVar = firstStrVar + " " + secondStrVar + "!";
        string resultStr = (string)objVar;
        Console.WriteLine(resultStr);
    }
}
