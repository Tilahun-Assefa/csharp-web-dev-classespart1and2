using System;
namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.
        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa           
            double totalQualityScore = Gpa * NumberOfCredits + courseCredits * grade;
            NumberOfCredits += courseCredits;
            Gpa = totalQualityScore / NumberOfCredits;
        }

        //TODO: Complete the GetGradeLevel method here:
        public string GetGradeLevel(int credits)
        {
            // Determine the grade level of the student based on NumberOfCredits
            if (credits <= 29)
            {
                return "Freshman";
            }
            else if (credits <= 59)
            {
                return "Sophomore";
            }
            else if (credits <= 89)
            {
                return "Junior";
            }
            else
            {
                return "Senior";
            }
        }

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.
        public override string ToString()
        {
            return $"Name:{Name} with ID {StudentId} score {Gpa} Gpa after taking {NumberOfCredits} credit hours";
        }

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.
        public override bool Equals(object obj)
        {
            return obj is Student student && Name == student.Name && StudentId == student.StudentId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, StudentId);
        }
    }
}
