using CalculatorExample;
using System;
using Xunit;

namespace XUnitTestProject
{
    public class CalculatorTest
    {
        [Fact]
        public void CreateCalculator()
        {
            ICalculator c = new Calculator();
            Assert.Equal(0, c.Result);
        }

        [Theory]
        [InlineData(0, 1, 1)]
        [InlineData(0, -1, -1)]
        [InlineData(123, 1, 124)]
        [InlineData(-321, -1, -322)]
        [InlineData(0, int.MaxValue, int.MaxValue)]
        [InlineData(0, int.MinValue, int.MinValue)]
        [InlineData(123, int.MaxValue - 123, int.MaxValue)]
        [InlineData(-234, int.MinValue + 234, int.MinValue)]
        public void AddValidValue(int initialValue, int x, int expected)
        {
            // Arrange
            ICalculator c = new Calculator();
            c.Add(initialValue);

            // Act
            c.Add(x);

            // Assert
            Assert.Equal(expected, c.Result);
        }

        [Fact]
        public void AddWithOverflowExpectOverflowException()
        {
            // Arrange
            ICalculator c = new Calculator();
            c.Add(int.MaxValue);

            // Act + Assert
            var ex = Assert.Throws<OverflowException>( () =>
            {
                c.Add(1);
            });

            Assert.Equal("Overflow", ex.Message);
        }
    }
}
