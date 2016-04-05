namespace AsyncAwait
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    internal class Program
    {
        private static async void Main(string[] args)
        {
            var task1 = ReadDataFromIOAsync();
            var task2 = ReadDataFromIOAsync();

            // Here we can do more processing
            // that doesn't need the data from the previous calls.
            // Now we need the data so we have to wait
            await Task.WhenAll(task1, task2);

            // Now we have data to show.
            var t1 = task1.Result;
            var t2 = task2.Result;
        }

        private async void btnRun_Click(object sender, EventArgs e)
        {
            await GetDataAsync();
        }

        private async Task GetDataAsync()
        {
            var task1 = ReadDataFromIOAsync();
            var task2 = ReadDataFromIOAsync();

            await Task.WhenAll(task1, task2);

            double t1 = await task1;
            double t2 = await task2;
        }

        public static Task<double> ReadDataFromIOAsync()
        {
            return Task.Run(new Func<double>(ReadDataFromIO));
        }

        public static double ReadDataFromIO()
        {
            // We are simulating an I/O by putting the current thread to sleep.
            Thread.Sleep(2000);
            return 10d;
        }
    }
}