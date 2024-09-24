using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class UtilityOperations
    {
        // Create a method to return the maximum of two numbers
        public double Maximum(double num1, double num2)
        {
            return Math.Max(num1, num2);
        }

        // Create a method to return the minimum of two numbers
        public double Minimum(double num1, double num2)
        {
            return Math.Min(num1, num2);
        }

        // Create a method to determine whether a number is a prime number
        public bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
