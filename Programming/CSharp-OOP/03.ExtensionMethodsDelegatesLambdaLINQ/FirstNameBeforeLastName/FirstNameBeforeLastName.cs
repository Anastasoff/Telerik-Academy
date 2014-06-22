// 3. Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//      Use LINQ query operators.
namespace FirstNameBeforeLastName
{
    public class FirstNameBeforeLastName
    {
        public static void Main()
        {
            Student[] students =
            {
                new Student("Pesho", "Peshev"),
                new Student("Gosho", "Georgiev"),
                new Student("Haralampi", "Popov"),
                new Student("Atanas", "Atanasov")
            };

            Filter inputArray = new Filter(students);
            inputArray.OrderBy();

            System.Console.WriteLine("Car".CompareTo("Car"));
        }
    }
}