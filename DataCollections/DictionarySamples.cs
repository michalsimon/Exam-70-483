namespace DataCollections
{
    using System.Collections.Generic;
    using System.Diagnostics;

    public class DictionarySamples
    {
        public static void Sample1()
        {
            Dictionary<int, MyRecord> myDictionary = new Dictionary<int, MyRecord>();

            myDictionary.Add(5, new MyRecord() { ID = 5, FirstName = "Bob", LastName = "Smith" });
            myDictionary.Add(2, new MyRecord() { ID = 2, FirstName = "Jane", LastName = "Doe" });
            myDictionary.Add(10, new MyRecord() { ID = 10, FirstName = "Bill", LastName = "Jones" });

            Debug.WriteLine(myDictionary[5].FirstName);
            Debug.WriteLine(myDictionary[2].FirstName);
            Debug.WriteLine(myDictionary[10].FirstName);
        }

        private class MyRecord
        {
            public int ID { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }
        }
    }
}