using CourseraAlgsSanDiego.DataStructures;
using Xunit;

namespace CourseraAlgsSanDiegoTests.DataStructures
{
    public class Week1Task1CheckBracketsInTheCodeTest
    {
        private Week1Task1CheckBracketsInTheCode target = new Week1Task1CheckBracketsInTheCode();

        [Theory]
        [InlineData("[]")]
        [InlineData("{}[]")]
        [InlineData("[()]")]
        [InlineData("{[]}()")]
        [InlineData("foo(bar)")]
        [InlineData("([])[]()")]
        [InlineData("((([([])]))())")]
        public void CheckBracketsTest_Balanced(string expression)
        {
            // Arrange
            var expected = "Success";

            // Act
            var actual = target.CheckBrackets(expression);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("{[")]
        [InlineData("[[")]
        public void CheckBracketsTest_Unbalanced1(string expression)
        {
            // Arrange
            var expected = "2";

            // Act
            var actual = target.CheckBrackets(expression);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("{[}")]
        public void CheckBracketsTest_Unbalanced2(string expression)
        {
            // Arrange
            var expected = "3";

            // Act
            var actual = target.CheckBrackets(expression);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("][")]
        public void CheckBracketsTest_Unbalanced3(string expression)
        {
            // Arrange
            var expected = "1";

            // Act
            var actual = target.CheckBrackets(expression);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("[")]
        public void CheckBracketsTest_Unbalanced4(string expression)
        {
            // Arrange
            var expected = "1";

            // Act
            var actual = target.CheckBrackets(expression);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("]")]
        public void CheckBracketsTest_Unbalanced5(string expression)
        {
            // Arrange
            var expected = "1";

            // Act
            var actual = target.CheckBrackets(expression);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("(){[}")]
        public void CheckBracketsTest_Unbalanced6(string expression)
        {
            // Arrange
            var expected = "5";

            // Act
            var actual = target.CheckBrackets(expression);
                
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckBracketsTest_Unbalanced7()
        {
            // Arrange
            var expression = "[](()()()";
            var expected = "3";

            // Act
            var actual = target.CheckBrackets(expression);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckBracketsTest_Unbalanced8()
        {
        // Arrange
        var expression = "[[]}]{}";
        var expected = "4";

        // Act
        var actual = target.CheckBrackets(expression);

        // Assert
        Assert.Equal(expected, actual);
        }
    }
}
