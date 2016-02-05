namespace DataCollections
{
    using System.Collections;
    using System.Diagnostics;

    public class HashTableSamples
    {
        public static void Sample1()
        {
            Hashtable myHashtable = new Hashtable();

            myHashtable.Add(1, "one");
            myHashtable.Add("two", 2);
            myHashtable.Add(3, "three");

            Debug.WriteLine(myHashtable[1].ToString());
            Debug.WriteLine(myHashtable["two"].ToString());
            Debug.WriteLine(myHashtable[3].ToString());
        }
    }
}