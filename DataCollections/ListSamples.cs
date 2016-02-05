namespace DataCollections
{
    using System.Collections.Generic;
    using System.Diagnostics;

    public class ListSamples
    {
        public static void Sample1()
        {
            List<int> myList = new List<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            foreach (int i in myList)
            {
                Debug.WriteLine(i.ToString());
            }
        }
    }
}