// 4. Create a class Person with two fields – name and age. 
// Age can be left unspecified (may contain null value. 
// Override ToString() to display the information of a person and if age is not specified – to say so. 
// Write a program to test this functionality.

namespace Person
{
    using System;

    public class Test
    {
        public static void Main()
        {
            Person pesho = new Person("Pesho");
            Console.WriteLine(pesho);
            pesho.Age = 33;
            Console.WriteLine(pesho);
            Person ivan = new Person("Ivan", 45);
            Console.WriteLine(ivan);
        }
    }
}
