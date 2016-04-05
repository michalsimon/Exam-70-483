namespace Events
{
    using System;

    public class OverdrawnEventArgs : EventArgs
    {
        public decimal CurrentBalance;

        public decimal DebitAmount;

        public OverdrawnEventArgs(decimal currentBalance, decimal debitAmount)
        {
            CurrentBalance = currentBalance;
            DebitAmount = debitAmount;
        }
    }
}