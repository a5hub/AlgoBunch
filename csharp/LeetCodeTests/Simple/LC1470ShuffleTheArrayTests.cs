using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class LC1470ShuffleTheArrayTests
    {
        private LC1470ShuffleTheArray target = new LC1470ShuffleTheArray();

        [Fact]
        public void ShuffleTest_Simple_WorksFine()
        {
            // Arrange
            var array = new [] {1, 2, 3, 4, 5, 6};
            var n = 3;

            var expected = new [] {1, 4, 2, 5, 3, 6};

            //Act
            var actual = target.Shuffle(array, 3);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShuffleTest_Site1_WorksFine()
        {
            // Arrange
            var array = new [] {2,5,1,3,4,7};
            var n = 3;

            var expected = new [] {2,3,5,4,1,7};

            //Act
            var actual = target.Shuffle(array, 3);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShuffleTest_Site2_WorksFine()
        {
            // Arrange
            var array = new [] {1,2,3,4,4,3,2,1};
            var n = 3;

            var expected = new [] {1,4,2,3,3,2,4,1};

            //Act
            var actual = target.Shuffle(array, 3);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShuffleTest_Site3_WorksFine()
        {
            // Arrange
            var array = new [] {1,1,2,2};
            var n = 3;

            var expected = new [] {1,2,1,2};

            //Act
            var actual = target.Shuffle(array, 3);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
