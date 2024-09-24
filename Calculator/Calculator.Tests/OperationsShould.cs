namespace Calculator.Tests
{
    public class OperationsShould
    {
        private readonly Operations _operations;

        public OperationsShould()
        {
            _operations = new Operations();
        }

        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            double result = _operations.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_PositiveAndNegativeNumber_ReturnsSum()
        {
            double result = _operations.Add(5, -3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Add_TwoNegativeNumbers_ReturnsSum()
        {
            double result = _operations.Add(-2, -3);
            Assert.Equal(-5, result);
        }

        [Fact]
        public void Add_NumberAndZero_ReturnsSameNumber()
        {
            double result = _operations.Add(5, 0);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_ZeroAndNumber_ReturnsSameNumber()
        {
            double result = _operations.Add(0, 5);
            Assert.Equal(5, result);
        }
        [Fact]
        public void Subtract_TwoPositiveNumbers_ReturnsDifference()
        {
            double result = _operations.Subtract(5, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Subtract_PositiveAndNegativeNumber_ReturnsSum()
        {
            double result = _operations.Subtract(5, -3);
            Assert.Equal(8, result);
        }

        [Fact]
        public void Subtract_TwoNegativeNumbers_ReturnsDifference()
        {
            double result = _operations.Subtract(-5, -3);
            Assert.Equal(-2, result);
        }

        [Fact]
        public void Subtract_NumberAndZero_ReturnsSameNumber()
        {
            double result = _operations.Subtract(5, 0);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Subtract_ZeroAndNumber_ReturnsNegativeNumber()
        {
            double result = _operations.Subtract(0, 5);
            Assert.Equal(-5, result);
        }
        [Fact]
        public void IsPrime_NumberLessThanOrEqualToOne_ReturnsFalse()
        {
            Assert.False(_operations.IsPrime(0));
            Assert.False(_operations.IsPrime(1));
            Assert.False(_operations.IsPrime(-5));
        }

        [Fact]
        public void IsPrime_Two_ReturnsTrue()
        {
            Assert.True(_operations.IsPrime(2));
        }

        [Fact]
        public void IsPrime_EvenNumberGreaterThanTwo_ReturnsFalse()
        {
            Assert.False(_operations.IsPrime(4));
            Assert.False(_operations.IsPrime(6));
            Assert.False(_operations.IsPrime(100));
        }

        [Fact]
        public void IsPrime_PrimeNumbers_ReturnsTrue()
        {
            Assert.True(_operations.IsPrime(3));
            Assert.True(_operations.IsPrime(5));
            Assert.True(_operations.IsPrime(7));
            Assert.True(_operations.IsPrime(11));
            Assert.True(_operations.IsPrime(13));
        }

        [Fact]
        public void IsPrime_NonPrimeOddNumbers_ReturnsFalse()
        {
            Assert.False(_operations.IsPrime(9));
            Assert.False(_operations.IsPrime(15));
            Assert.False(_operations.IsPrime(21));
        }

        [Fact]
        public void IsPrime_LargePrimeNumber_ReturnsTrue()
        {
            Assert.True(_operations.IsPrime(7919)); // Example of a large prime number
        }

        [Fact]
        public void IsPrime_LargeNonPrimeNumber_ReturnsFalse()
        {
            Assert.False(_operations.IsPrime(8000)); // Example of a large non-prime number
        }

        [Fact]
        public void Factorial_NegativeNumber_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _operations.Factorial(-1));
        }
    }
}