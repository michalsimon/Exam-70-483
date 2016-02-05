namespace Reflection
{
    using System;

    public class Calculator
    {
        public double X { get; set; }

        public double Y { get; set; }

        public double Divide()
        {
            if (this.Y == 0)
            {
                return 0;
            }
            else
            {
                return this.X / this.Y;
            }
        }

        public double Exponent(double power)
        {
            return Math.Pow(this.X, power);
        }
    }
}