namespace DataCollections
{
    using System.Diagnostics;

    public class CustomCollectionSamples
    {
        public static void Sample1()
        {
            PersonCollection persons = new PersonCollection();

            persons.Add(new Person() { PersonId = 1, FName = "John", LName = "Smith" });

            persons.Add(new Person() { PersonId = 2, FName = "Jane", LName = "Doe" });

            persons.Add(new Person() { PersonId = 3, FName = "Bill Jones", LName = "Smith" });

            foreach (Person person in persons)
            {
                Debug.WriteLine(person.FName);
            }
        }
    }
}