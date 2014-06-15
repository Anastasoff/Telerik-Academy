namespace SchoolDemo
{
    using School;
    public class SchoolDemo
    {
        public static void Main(string[] args)
        {
            School school = new School();
            Course course = new Course();
            Student student = new Student("John", school);
        }
    }
}