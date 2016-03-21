namespace Encapsulation
{
    using System;

    public class Student
    {
        private int age;

        private double gpa;

        public Student(string first, string last)
        {
            this.FirstName = first;
            this.LastName = last;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char MiddleInitial { get; set; }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 6)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Student age must be greater than 6");
                }
            }
        }

        public string Program { get; set; }
        public double GPA
        {
            get
            {
                return gpa;
            }
            set
            {
                if (value <= 4.0)
                {
                    gpa = value;
                }
                else
                {
                    Console.WriteLine("GPA cannot be greater than 4.0");
                }
            }
        }

        public void displayDetails()
        {
            Console.WriteLine(this.FirstName + " " + this.MiddleInitial + " " + this.LastName);
            Console.WriteLine("Has a GPA of " + this.GPA);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Student myStudent = new Student("Tom", "Thumb");
            myStudent.MiddleInitial = 'R';
            myStudent.Age = 15;
            myStudent.GPA = 3.5;
            myStudent.displayDetails();

            Console.ReadLine();
        }
    }
}