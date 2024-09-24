using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Operations
    {
        // Create a method to add two numbers
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        // Create a method to subtract the second number from the first
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        // Create a method to multiply two numbers
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        // Create a method to divide the first number by the second
        public double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return num1 / num2;
        }

        // Create a method to calculate the modulus of two numbers
        public double Modulus(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Modulus by zero is not allowed.");
            }
            return num1 % num2;
        }

        // Create a method to calculate the power of a number
        public double Power(double baseNum, double exponent)
        {
            return Math.Pow(baseNum, exponent);
        }

        // Create a method to calculate the square root of a number
        public double SquareRoot(double num)
        {
            if (num < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(num), "Cannot calculate the square root of a negative number.");
            }
            return Math.Sqrt(num);
        }

        // Create a method to calculate the absolute value of a number
        public double AbsoluteValue(double num)
        {
            return Math.Abs(num);
        }

        /// <summary>
        /// Calculates the factorial of a non-negative number.
        /// </summary>
        /// <param name="number">The number to calculate the factorial for.</param>
        /// <returns>The factorial of the given number.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the number is negative.</exception>
        public double Factorial(double number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Cannot calculate the factorial of a negative number.");
            }

            if (number == 0)
            {
                return 1;
            }

            return number * Factorial(number - 1);
        }

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
