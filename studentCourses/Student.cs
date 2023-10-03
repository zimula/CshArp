using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentCourses
{
    internal class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Course>? Courses { get; set; }

        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;   
            Courses = new List<Course>();
        }
        //methhod to enroll
        public void AddCourse(Course course)
        {
            Courses.Add(course);
            Console.WriteLine($"Enrolled in course: {course.CourseName}");
        }
    }
}
