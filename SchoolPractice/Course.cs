using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        public string Topic { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> EnrolledStudents { get; set; } = new List<Student>();

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather than
        //  just the class fields.
        public override string ToString()
        {
            return $"The course {Topic} is given by Instructor {Instructor.FirstName} ";
        }

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Course objects equal.
        public override bool Equals(object obj)
        {
            return obj is Course course &&
                   Topic == course.Topic &&
                   EqualityComparer<Teacher>.Default.Equals(Instructor, course.Instructor);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Topic, Instructor);
        }
    }
}
