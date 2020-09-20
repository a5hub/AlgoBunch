using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class LC1582SpecialPositionsInABinaryMatrixTests
    {
        private LC1582SpecialPositionsInABinaryMatrix target = new LC1582SpecialPositionsInABinaryMatrix();

        [Fact]
        public void NumSpecialTest3x3_WorksFine()
        {
            // Arrange
            var size = 3;
            var array = new int[size][];
            var j = 0;
            for (int i = 0; i < size; i++)
            {
                array[i] = new int[size];
                array[i][j] = 1;
                j++;
            }

            var expected = 3;

            // Act
            var actual = target.NumSpecial(array);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NumSpecialTest100x100_WorksFine()
        {
            // Arrange
            var size = 100;
            var array = new int[size][];
            var j = 0;
            for (int i = 0; i < size; i++)
            {
                array[i] = new int[size];
                array[i][j] = 1;
                j++;
            }

            var expected = 100;

            // Act
            var actual = target.NumSpecial(array);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void NumSpecialTest100x100_98Result()
        {
            // Arrange
            var size = 100;
            var array = new int[size][];
            var j = 0;
            for (int i = 0; i < size; i++)
            {
                array[i] = new int[size];
                array[i][j] = 1;
                j++;
            }

            array[0][1] = 1;

            var expected = 98;

            // Act
            var actual = target.NumSpecial(array);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NumSpecialTest1_SiteTest()
        {
            // Arrange
            var array = new []
            {
                new [] {0,0,1,0}, 
                new [] {0,0,0,0},
                new [] {0,0,0,0},
                new [] {0,1,0,0}
            };

            var expected = 2;

            // Act
            var actual = target.NumSpecial(array);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
