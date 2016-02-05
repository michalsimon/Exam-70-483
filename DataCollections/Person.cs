namespace DataCollections
{
    using System.Collections;

    public class Person
    {
        public int PersonId { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }
    }

    public class PersonCollection : CollectionBase
    {
        public void Add(Person person)
        {
            List.Add(person);
        }

        public void Insert(int index, Person person)
        {
            List.Insert(index, person);
        }

        public Person this[int index]
        {
            get
            {
                return (Person)List[index];
            }

            set
            {
                List[index] = value;
            }
        }

        public void Remove(Person person)
        {
            List.Remove(person);
        }
    }
}