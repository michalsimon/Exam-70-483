namespace BaseClass
{
    using System;

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor with first name.
        public Person(string firstName)
        {
            // Validate the first name.
            if ((firstName == null) || (firstName.Length < 1))
            {
                throw new ArgumentOutOfRangeException("firstName", firstName, "FirstName must not be null or blank.");
            }

            // Save first name.
            FirstName = firstName;
        }

        public Person(string firstName, string lastName)
            : this(firstName)
        {
            // Validate the last name.
            if ((lastName == null) || (lastName.Length < 1))
            {
                throw new ArgumentOutOfRangeException("lastName", lastName, "LastName must not be null or blank.");
            }

            // Save last name.
            LastName = lastName;
        }
    }

    public class Employee : Person
    {
        public Employee(string firstName, string lastName, string departmentName)
            : base(firstName, lastName)
        {
            // / Validate the department name.
            if ((departmentName == null) || (departmentName.Length < 1))
            {
                throw new ArgumentOutOfRangeException(
                    "departmentName", 
                    departmentName, 
                    "DepartmentName must not be null or blank.");
            }

            // Save the department name.
            this.DepartmentName = departmentName;
        }

        public string DepartmentName { get; set; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }
}