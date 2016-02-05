namespace DataCollections
{
    using System.Collections;
    using System.Diagnostics;

    public class QueueSamples
    {
        public static void Sample1()
        {
            Queue myQueue = new Queue();

            myQueue.Enqueue("first");
            myQueue.Enqueue("second");
            myQueue.Enqueue("third");

            int count = myQueue.Count;
            for (int i = 0; i < count; i++)
            {
                Debug.WriteLine(myQueue.Dequeue());
            }
        }
    }
}