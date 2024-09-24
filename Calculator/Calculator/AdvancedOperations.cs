using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class AdvancedOperations
    {
        /// <summary>
        /// Calculates the power of a number.
        /// </summary>
        /// <param name="baseNum">The base number.</param>
        /// <param name="exponent">The exponent.</param>
        /// <returns>The result of raising the base number to the power of the exponent.</returns>
        /// <exception cref="ArgumentException">Thrown when the base number is zero and the exponent is negative.</exception>
        public double Power(double baseNum, double exponent)
        {
            if (baseNum == 0 && exponent < 0)
            {
                throw new ArgumentException("Cannot raise zero to a negative power because it results in an undefined operation (division by zero).");
            }

            return Math.Pow(baseNum, exponent);
        }

        /// <summary>
        /// Calculates the square root of a number.
        /// </summary>
        /// <param name="number">The number to calculate the square root for.</param>
        /// <returns>The square root of the given number.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the number is negative.</exception>
        public double SquareRoot(double number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Cannot calculate the square root of a negative number.");
            }
            return Math.Sqrt(number);
        }

        /// <summary>
        /// Calculates the absolute value of a number.
        /// </summary>
        /// <param name="number">The number to calculate the absolute value for.</param>
        /// <returns>The absolute value of the given number.</returns>
        /// <exception cref="ArgumentException">Thrown when the input is NaN or infinity.</exception>
        public double AbsoluteValue(double number)
        {
            if (double.IsNaN(number))
            {
                throw new ArgumentException("Input cannot be NaN (Not a Number).", nameof(number));
            }

            if (double.IsInfinity(number))
            {
                throw new ArgumentException("Input cannot be infinity.", nameof(number));
            }

            return Math.Abs(number);
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
    }
}
