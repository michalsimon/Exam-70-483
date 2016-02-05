namespace DataCollections
{
    using System.Collections;
    using System.Diagnostics;

    public class StackSamples
    {
        public static void Sample1()
        {
            Stack myStack = new Stack();

            myStack.Push("first");
            myStack.Push("second");
            myStack.Push("third");

            int count = myStack.Count;
            for (int i = 0; i < count; i++)
            {
                Debug.WriteLine(myStack.Pop());
            }
        }
    }
}