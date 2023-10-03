namespace studentCourses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Student m = new Student(1, "martin");
            Course x = new Course(1,"science");
            m.AddCourse(x);
        }
    }
}