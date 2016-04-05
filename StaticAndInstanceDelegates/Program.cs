using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndInstanceDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make some Persons.
            Person alice = new Person() { Name = "Alice" };
            Person bob = new Person() { Name = "Bob" };

            // Make Alice's InstanceMethod variable refer to her own GetName method.
            alice.InstanceMethod = alice.GetName;
            alice.StaticMethod = Person.StaticName;

            // Make Bob's InstanceMethod variable refer to Alice's GetName method.
            bob.InstanceMethod = alice.GetName;
            bob.StaticMethod = Person.StaticName;

            // Demonstrate the methods.
            string result = "";
            result += "Alice's InstanceMethod returns: " + alice.InstanceMethod() + Environment.NewLine;
            result += "Bob's InstanceMethod returns: " + bob.InstanceMethod() + Environment.NewLine;
            result += "Alice's StaticMethod returns: " + alice.StaticMethod() + Environment.NewLine;
            result += "Bob's StaticMethod returns: " + bob.StaticMethod();

            Console.Write(result);
            Console.ReadKey();
        }
    }
}
