using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class ArithmeticOperations
    {
        /// <summary>
        /// Adds two double-precision floating-point numbers.
        /// </summary>
        /// <param name="num1">The first number to add.</param>
        /// <param name="num2">The second number to add.</param>
        /// <returns>The sum of num1 and num2.</returns>
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        /// <summary>
        /// Subtracts the second double-precision floating-point number from the first.
        /// </summary>
        /// <param name="num1">The number from which to subtract.</param>
        /// <param name="num2">The number to subtract.</param>
        /// <returns>The difference between num1 and num2.</returns>
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        /// <summary>
        /// Multiplies two double-precision floating-point numbers.
        /// </summary>
        /// <param name="num1">The first number to multiply.</param>
        /// <param name="num2">The second number to multiply.</param>
        /// <returns>The product of num1 and num2.</returns>
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        /// <summary>
        /// Divides the first double-precision floating-point number by the second.
        /// </summary>
        /// <param name="num1">The number to be divided.</param>
        /// <param name="num2">The number by which to divide.</param>
        /// <returns>The quotient of num1 divided by num2.</returns>
        /// <exception cref="DivideByZeroException">Thrown when num2 is zero.</exception>
        public double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return num1 / num2;
        }

        /// <summary>
        /// Calculates the modulus of two double-precision floating-point numbers.
        /// </summary>
        /// <param name="num1">The number to be divided.</param>
        /// <param name="num2">The number by which to divide.</param>
        /// <returns>The remainder of num1 divided by num2.</returns>
        /// <exception cref="DivideByZeroException">Thrown when num2 is zero.</exception>
        public double Modulus(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Modulus by zero is not allowed.");
            }
            return num1 % num2;
        }
    }
}
