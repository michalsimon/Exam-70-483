namespace ExceptionHandling
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            NoException();

            CaughtException();

            try
            {
                UnCaughtException();
            }
            catch
            {
            }

            try
            {
                CatchThrowsException();
            }
            catch
            {
            }

            TryReturns();

            CatchReturns();

            Console.ReadKey();
        }

        // Try block has no exception.
        private static void NoException()
        {
            try
            {
                Console.Write("NoException try");
            }
            catch
            {
                Console.Write("NoException catch");
            }
            finally
            {
                Console.Write("NoException finally");
            }
        }

        // Try block has an exception that is caught by a catch block.
        private static void CaughtException()
        {
            try
            {
                Console.Write("CaughtException try");
                throw new ArgumentException("Invalid argument.");
            }
            catch
            {
                Console.Write("CaughtException catch");
            }
            finally
            {
                Console.Write("CaughtException finally");
            }
        }

        // Try block has an exception that is not caught by a catch block.
        private static void UnCaughtException()
        {
            try
            {
                Console.Write("UnCaughtException try");
                throw new ArgumentException("Invalid argument.");
            }
            catch (FormatException)
            {
                Console.Write("UnCaughtException catch");
            }
            finally
            {
                Console.Write("UnCaughtException finally");
            }
        }

        // Try block has an exception that is caught by a catch block
        // and the catch block throws another exception.
        private static void CatchThrowsException()
        {
            try
            {
                Console.Write("CatchThrowsException try");
                throw new ArgumentException("Invalid argument.");
            }
            catch (ArgumentException)
            {
                Console.Write("CatchThrowsException catch");
                throw new FormatException("Invalid format.");
            }
            finally
            {
                Console.Write("CatchThrowsException finally");
            }
        }

        // Try block uses a return statement.
        private static void TryReturns()
        {
            try
            {
                Console.Write("TryReturns try");
                return;
            }
            catch
            {
                Console.Write("TryReturns catch");
            }
            finally
            {
                Console.Write("TryReturns finally");
            }
        }

        // Catch block uses a return statement.
        private static void CatchReturns()
        {
            try
            {
                Console.Write("CatchReturns try");
                throw new ArgumentException("Invalid argument.");
            }
            catch
            {
                Console.Write("CatchReturns catch");
                return;
            }
            finally
            {
                Console.Write("CatchReturns finally");
            }
        }
    }
}