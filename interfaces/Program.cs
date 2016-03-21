using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // Constructor with first name.

        public Person() { }

        public Person(string firstName)
        {
            FirstName = firstName;
        }
        // Constructor with first and last name.
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public class Faculty
    {
    }

    public interface IStudent
    {
        // The student's list of current courses.
        List<string> Courses { get; set; }
        // Print the student's current grades.
        void PrintGrades();
    }

    public class Student : Person, IStudent
    {
        // Implement IStudent.Courses.
        // The student's list of current courses.
        public List<string> Courses { get; set; }
        // Implement IStudent.PrintGrades.
        // Print the student's current grades.
        public void PrintGrades()
        {
            // Do whatever is necessary...
        }
    }

    public class TeachingAssistant : Faculty, IStudent
    {
        // Implement IStudent.Courses.
        // The student's list of current courses.
        public List<string> Courses { get; set; }
        // Implement IStudent.PrintGrades.
        // Print the student's current grades.
        public void PrintGrades()
        {
            // Do whatever is necessary...
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
