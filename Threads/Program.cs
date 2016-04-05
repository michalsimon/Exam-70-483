namespace Threads
{
    using System;
    using System.Diagnostics;
    using System.Threading;

    internal class Program
    {
        private static void Main(string[] args)
        {
            // We are using Stopwatch to time the code
            Stopwatch sw = Stopwatch.StartNew();

            // Here we call different methods for different ways of running our application. 
            RunInThreadPool();

            // Print the time it took to run the application.
            Console.WriteLine("We're done in {0}ms!", sw.ElapsedMilliseconds);

            Utils.CommonFunctions.WaitForKeyWhehDebugging();
        }

        private static void RunSequencial()
        {
            double result = 0d;

            // Call the function to read data from I/O
            result += Utils.CommonFunctions.ReadDataFromIO();

            // Add the result of the second calculation 
            result += Utils.CommonFunctions.DoIntensiveCalculations();

            // Print the result
            Console.WriteLine("The result is {0}", result);
        }

        private static void RunWithThreads()
        {
            double result = 0d;

            // Create the thread to read from I/O
            var thread = new Thread(() => result = Utils.CommonFunctions.ReadDataFromIO());

            // Start the thread
            thread.Start();

            // Save the result of the calculation into another variable
            double result2 = Utils.CommonFunctions.DoIntensiveCalculations();

            // Wait for the thread to finish
            thread.Join();

            // Calculate the end result
            result += result2;

            // Print the result
            Console.WriteLine("The result is {0}", result);
        }

        private static void RunInThreadPool()
        {
            double result = 0d;

            // Create a work item to read from I/O
            ThreadPool.QueueUserWorkItem((x) => result += Utils.CommonFunctions.ReadDataFromIO());

            // Save the result of the calculation into another variable
            double result2 = Utils.CommonFunctions.DoIntensiveCalculations();

            // Wait for the thread to finish
            // TODO: We will need a way to indicate that the thread pool thread finished the execution

            // Calculate the end result
            result += result2;

            // Print the result
            Console.WriteLine("The result is {0}", result);
        }

        private static void RunInThreadPoolWithEvents()
        {
            double result = 0d;

            // We use this event to signal when the thread is don executing. 
            EventWaitHandle calculationDone = new EventWaitHandle(false, EventResetMode.AutoReset);

            // Create a work item to read from I/O
            ThreadPool.QueueUserWorkItem(
                (x) =>
                    {
                        result += Utils.CommonFunctions.ReadDataFromIO();
                        calculationDone.Set();
                    });

            // Save the result of the calculation into another variable
            double result2 = Utils.CommonFunctions.DoIntensiveCalculations();

            // Wait for the thread to finish
            calculationDone.WaitOne();

            // Calculate the end result
            result += result2;

            // Print the result
            Console.WriteLine("The result is {0}", result);
        }
    }
}