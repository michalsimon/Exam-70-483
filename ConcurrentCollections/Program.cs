namespace ConcurrentCollections
{
    using System;
    using System.Collections.Concurrent;
    using System.Threading.Tasks;

    internal class Program
    {
        private static void Main(string[] args)
        {
            BlockingCollectionSample();

            ConcurrentBagSample();

            ConcurrentStackSample();

            ConcurrentQueueSample();

            ConcurrentDictionarySample();
        }

        private static void ConcurrentDictionarySample()
        {
            var dict = new ConcurrentDictionary<string, int>();
            if (dict.TryAdd("k1", 42))
            {
                Console.WriteLine("Added");
            }
            if (dict.TryUpdate("k1", 21, 42))
            {
                Console.WriteLine("42 updated to 21");
            }
            dict["k1"] = 42; // Overwrite unconditionally
            int r1 = dict.AddOrUpdate("k1", 3, (s, i) => i * 2);
            int r2 = dict.GetOrAdd("k2", 3);
        }

        private static void ConcurrentQueueSample()
        {
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
            queue.Enqueue(42);
            int result;
            if (queue.TryDequeue(out result))
            {
                Console.WriteLine("Dequeued: {0}", result);
            }
        }

        private static void ConcurrentStackSample()
        {
            ConcurrentStack<int> stack = new ConcurrentStack<int>();
            stack.Push(42);
            int result;
            if (stack.TryPop(out result))
            {
                Console.WriteLine("Popped: {0}", result);
            }
            stack.PushRange(new[] { 1, 2, 3 });
            int[] values = new int[2];
            stack.TryPopRange(values);
            foreach (int i in values)
            {
                Console.WriteLine(i);
            }
        }

        private static void ConcurrentBagSample()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            bag.Add(42);
            bag.Add(21);
            int result;
            if (bag.TryTake(out result))
            {
                Console.WriteLine(result);
            }
            if (bag.TryPeek(out result))
            {
                Console.WriteLine("There is a next item: {0}", result);
            }
        }

        private static void BlockingCollectionSample()
        {
            BlockingCollection<string> col = new BlockingCollection<string>();
            Task read = Task.Run(
                () =>
                    {
                        while (true)
                        {
                            Console.WriteLine(col.Take());
                        }
                    });

            Task write = Task.Run(
                () =>
                    {
                        while (true)
                        {
                            string s = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(s))
                            {
                                break;
                            }
                            col.Add(s);
                        }
                    });
            write.Wait();
        }
    }
}