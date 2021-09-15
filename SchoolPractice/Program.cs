using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Test your exercise solutions with print statements here.
            Student til = new Student("Til");
            til.AddGrade(4, 3);
            til.AddGrade(3, 2);
            til.AddGrade(4, 4);
            Console.WriteLine(til.GetGradeLevel(til.NumberOfCredits));

            Teacher joey = new Teacher("Joey", "Cowsert", "JavaScript", 5);

            Course javascript = new Course();
            javascript.Topic = joey.Subject;
            javascript.Instructor = joey;
            javascript.EnrolledStudents.Add(til);
            Console.WriteLine($"{til}. He takes {javascript}");
            til.AddGrade(4, 2);
            Console.WriteLine($"{til}.");
        }
    }
}
