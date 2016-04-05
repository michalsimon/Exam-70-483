namespace Continuations
{
    using System;
    using System.Threading.Tasks;

    internal class Program
    {
        private static void Main(string[] args)
        {
            independentTasks();

            Task3OnlyAfterTask1();

            Task3AfterTask1AndTask2();

            Task3AfterTask1OrTask2();
        }

        private static void Task3AfterTask1OrTask2()
        {
            Task step1Task = Task.Run(() => Step1());
            Task step2Task = Task.Run(() => Step2());
            Task step3Task = Task.Factory.ContinueWhenAny(
                new[] { step1Task, step2Task }, 
                (previousTask) => Step3());

            step3Task.Wait();
        }

        private static void Task3AfterTask1AndTask2()
        {
            Task step1Task = Task.Run(() => Step1());
            Task step2Task = Task.Run(() => Step2());
            Task step3Task = Task.Factory.ContinueWhenAll(new[] { step1Task, step2Task }, (previousTasks) => Step3());

            step3Task.Wait();
        }

        private static void Task3OnlyAfterTask1()
        {
            Task step1Task = Task.Run(() => Step1());
            Task step2Task = Task.Run(() => Step2());
            Task step3Task = step1Task.ContinueWith((previousTask) => Step3());

            Task.WaitAll(step2Task, step3Task);
        }

        private static void independentTasks()
        {
            // metody niezależne
            Parallel.Invoke(Step1, Step2, Step3);
        }

        private static void Step1()
        {
            Console.WriteLine("Step1");
        }

        private static void Step2()
        {
            Console.WriteLine("Step2");
        }

        private static void Step3()
        {
            Console.WriteLine("Step3");
        }
    }
}