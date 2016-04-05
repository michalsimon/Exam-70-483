namespace Events
{
    using System;

    internal class Program
    {
        // The bank account.
        private static BankAccount TheAccount;

        // The event handler with event args.
        private static void OverdrawnHandler(object sender, OverdrawnEventArgs args)
        {
            string message = "The account is overdrawn." + Environment.NewLine + "Current Balance: "
                             + args.CurrentBalance.ToString("C") + Environment.NewLine + "Debit Amount: "
                             + args.DebitAmount.ToString("C");
            Console.Write(message);
        }

        // Display the account balance.
        private static void DisplayBalance()
        {
            Console.Write(TheAccount.Balance.ToString("C"));
        }

        private static void Main(string[] args)
        {
            // Create the account.
            TheAccount = new BankAccount();
            TheAccount.Balance = 100m;

            // Subscribe to the Overdrawn event.
            TheAccount.Overdrawn += OverdrawnHandler;

            // Display the account balance.
            DisplayBalance();
            Console.ReadKey();
        }
    }
}