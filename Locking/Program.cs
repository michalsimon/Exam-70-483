namespace Locking
{
    using System.Threading;

    internal class Program
    {
        private static void Main(string[] args)
        {
            object syncObject = new object();

            LockThatMayLeadToException(syncObject);

            LockExceptionSafe(syncObject);

            // C# way of using locks
            lock (syncObject)
            {
                // Code updating some shared data
            }
        }

        private static void LockExceptionSafe(object syncObject)
        {
            // Exception safe usage
            Monitor.Enter(syncObject);
            try
            {
                // Code updating some shared data
            }
            finally
            {
                Monitor.Exit(syncObject);
            }
        }

        private static void LockThatMayLeadToException(object syncObject)
        {
            // wrong usage
            Monitor.Enter(syncObject);

            // Code updating some shared data
            Monitor.Exit(syncObject);
        }
    }
}