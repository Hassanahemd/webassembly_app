using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webassembly_app.Shared
{
    
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }

    
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public object Students { get; set; }
    }

}
