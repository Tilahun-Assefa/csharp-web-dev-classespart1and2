using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Course
    {
        public string CourseName { get; set; }
        public Teacher instructor { get; set; }
        public List<Student> enrolledStudents { get; set; }
    }
}
