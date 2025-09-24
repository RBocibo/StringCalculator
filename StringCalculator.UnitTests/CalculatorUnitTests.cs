namespace StringCalculator.UnitTests
{
    public class CalculatorUnitTests
    {
        [Fact]
        public void Add_NullOrEmptyString_Success()
        {
            // Arrange
            string input = "";

            // Act
            int result = Calculator.Add(input);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Add_OneNumber_Success()
        {
            // Arrange
            string input = "5";

            // Act
            int result = Calculator.Add(input);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_TwoNumbers_Success()
        {
            // Arrange
            string input = "3,5";

            // Act
            int result = Calculator.Add(input);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Add_ManyNumbers_Success()
        {
            // Arrange
            string input = "1,2,3,4,5";

            // Act
            int result = Calculator.Add(input);

            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void Add_NumbersWithNewLines_Success()
        {
            // Arrange
            string input = "1\n2,3";

            // Act
            int result = Calculator.Add(input);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Add_WhenMultipleDelimitersExist_Success()
        {
            // Arrange
            string input = "//;\n1;2";

            // Act
            int result = Calculator.Add(input);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Add_NegativeNumbers_ThrowsException_Print_WithAllNegativeNumbers_Success()
        {
            // Arrange
            string input = "1,-2,-3";

            // Act
            var exception = Assert.Throws<ArgumentException>(() => Calculator.Add(input));

            // Assert
            Assert.Contains("Negatives not allowed", exception.Message);
            Assert.Contains("-2", exception.Message);
            Assert.Contains("-3", exception.Message);
        }
    }
}