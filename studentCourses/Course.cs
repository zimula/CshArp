using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentCourses
{
    internal class Course
    {
        public int Id { get; set; } 
        public string? CourseName { get; set; }
        public Course(int id, string name)
        {
            this.Id = id;
            this.CourseName = name;
        }
    }
}
