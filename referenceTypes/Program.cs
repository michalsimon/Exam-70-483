namespace ReferenceTypes
{
    using System;

    // an abstract method inside a class
    public abstract class Student
    {
        public abstract void outputDetails();
    }
    public class CollegeStudent : Student
    {
        public string firstName;
        public string lastName;
        public string major;
        public double GPA;
        public override void outputDetails()
        {
            Console.WriteLine("Student " + firstName + " " + lastName +
            " enrolled in " + major + " is has a GPA of " + GPA);
        }
    }

    internal class SchoolStudent
    {
        public static int StudentCount;

        public string firstName;

        public string lastName;

        public string grade;

        public SchoolStudent(string first, string last, string grade)
        {
            this.firstName = first;
            this.lastName = last;
            this.grade = grade;
        }

        public SchoolStudent()
        {
        }

        public string ConcatenateName()
        {
            string fullName = this.firstName + " " + this.lastName;
            return fullName;
        }

        public void DisplayName()
        {
            string name = this.ConcatenateName();
            Console.WriteLine(name);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            SchoolStudent firstSchoolStudent = new SchoolStudent();
            SchoolStudent.StudentCount++;
            SchoolStudent secondSchoolStudent = new SchoolStudent();
            SchoolStudent.StudentCount++;
            firstSchoolStudent.firstName = "John";
            firstSchoolStudent.lastName = "Smith";
            firstSchoolStudent.grade = "six";
            secondSchoolStudent.firstName = "Tom";
            secondSchoolStudent.lastName = "Thumb";
            secondSchoolStudent.grade = "two";
            firstSchoolStudent.DisplayName();

            Console.ReadLine();
        }
    }
}