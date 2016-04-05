namespace CovarianceAndContravariance
{
    using System;

    internal class Program
    {
        // A delegate that returns a Person.
        private delegate Person ReturnPersonDelegate();

        // private ReturnPersonDelegate ReturnPersonMethod;
        private static Func<Person> ReturnPersonMethod;

        // A method that returns an Employee.
        private static Employee ReturnEmployee()
        {
            return new Employee();
        }

        // A delegate that takes an Employee as a parameter.
        private delegate void EmployeeParameterDelegate(Employee employee);

        private static EmployeeParameterDelegate EmployeeParameterMethod;

        // private Action<Employee> EmployeeParameterMethod;

        // A method that takes a Person as a parameter.
        private static void PersonParameter(Person person)
        {
        }

        private static void Main(string[] args)
        {
            // Set ReturnPersonMethod = ReturnEmployee.
            // Covariance allows this because ReturnPersonDelegate
            // returns a Person and an Employee is a kind of Person.
            ReturnPersonMethod = ReturnEmployee;

            // Set EmployeeParameterMethod = PersonParameter.
            // Contravariance allows this because EmployeeParameterDelegate
            // takes an Employee as a parameter and an Employee is a kind of Person.
            // In other words, when you invoke the delegate's method you will
            // pass it an Employee and an Employee is a kind of Person so
            // PersonParameter can handle it.
            EmployeeParameterMethod = PersonParameter;
        }
    }
}