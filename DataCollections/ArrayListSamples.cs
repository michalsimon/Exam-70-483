namespace DataCollections
{
    using System;
    using System.Collections;
    using System.Diagnostics;

    public class ArrayListSamples
    {
        public static void Sample1()
        {
            ArrayList myList = new ArrayList();

            myList.Add(1);
            myList.Add("hello world");
            myList.Add(new DateTime(2012, 01, 01));
        }

        public static void Sample2()
        {
            ArrayList myList = new ArrayList();

            myList.Add(4);
            myList.Add(1);
            myList.Add(5);
            myList.Add(3);
            myList.Add(2);

            myList.Sort();

            foreach (int i in myList)
            {
                Debug.WriteLine(i.ToString());
            }
        }

        public static void Sample3()
        {
            ArrayList myList = new ArrayList();

            myList.Add(new MyObject() { ID = 4 });
            myList.Add(new MyObject() { ID = 1 });
            myList.Add(new MyObject() { ID = 5 });
            myList.Add(new MyObject() { ID = 3 });
            myList.Add(new MyObject() { ID = 2 });

            myList.Sort();

            foreach (MyObject obj in myList)
            {
                Debug.WriteLine(obj.ID.ToString());
            }
        }

        public static void Sample4()
        {
            ArrayList myList = new ArrayList();

            myList.Add(new MyObject() { ID = 4 });
            myList.Add(new MyObject() { ID = 1 });
            myList.Add(new MyObject() { ID = 5 });
            myList.Add(new MyObject() { ID = 3 });
            myList.Add(new MyObject() { ID = 2 });

            myList.Sort();
            int foundIndex = myList.BinarySearch(new MyObject() { ID = 4 });

            if (foundIndex >= 0)
            {
                Debug.WriteLine(((MyObject)myList[foundIndex]).ID.ToString());
            }
            else
            {
                Debug.WriteLine("Element not found");
            }
        }
    }

    internal class MyObject : IComparable
    {
        public int ID { get; set; }

        public int CompareTo(object obj)
        {
            MyObject obj1 = obj as MyObject;
            return this.ID.CompareTo(obj1.ID);
        }
    }
}