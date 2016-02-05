namespace DataCollections
{
    using System.Collections;
    using System.Diagnostics;

    public class SortedListSamples
    {
        public static void Sample1()
        {
            SortedList mySortedList = new SortedList();

            mySortedList.Add(3, "three");
            mySortedList.Add(2, "second");
            mySortedList.Add(1, "first");

            foreach (DictionaryEntry item in mySortedList)
            {
                Debug.WriteLine(item.Value);
            }
        }
    }
}