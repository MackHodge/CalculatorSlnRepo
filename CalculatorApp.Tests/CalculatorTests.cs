namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Theory]
        [InlineData("3 + 5", 8)]
        [InlineData("10 - 2 * 3", 4)]
        [InlineData("4 * (2 + 3)", 20)]
        [InlineData("16 / 2 + 1", 9)]
        [InlineData("2 + 3 * 4", 14)]
        public void Evaluate_ValidExpression_ReturnsExpectedResult(string expression, double expected)
        {
            var result = _calculator.Evaluate(expression);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Evaluate_InvalidExpression_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => _calculator.Evaluate("3 + "));
        }
    }
}