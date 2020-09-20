using System;
using System.Collections.Generic;
using CourseraAlgsSanDiego.AlgorithmicToolbox;
using Xunit;

namespace CourseraAlgsSanDiegoTests
{
    public class Task4LongestCommonSubsequenceOfTwoTests
    {
        Week5Task4LongestCommonSubsequenceOfTwo target = new Week5Task4LongestCommonSubsequenceOfTwo();
        
        [Fact]
        public void EditDistanceTest_SameSubsequences()
        {
            // Arrange
            var list1 = new List<int>{0, 1, 2, 3};
            var list2 = new List<int>{0, 1, 2, 3};
            var expected = 3;

            // Act
            var actual = target.EditDistance(list1, list2).Item2;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EditDistanceTest_Samle3()
        {
            // Arrange
            var list1 = new List<int>{0, 2, 7, 8, 3};
            var list2 = new List<int>{0, 5, 2, 8, 7};
            var expected = 2;

            // Act
            var actual = target.EditDistance(list1, list2).Item2;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EditDistanceTest_Duplicates()
        {
            // Arrange
            var list1 = new List<int>{0, 2, 7, 2, 8, 3};
            var list2 = new List<int>{0, 5, 2, 8, 8, 7};
            var expected = 2;

            // Act
            var actual = target.EditDistance(list1, list2).Item2;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EditDistanceTest_Duplicates2()
        {
            // Arrange
            var list1 = new List<int>{0, 3, 3, 1};
            var list2 = new List<int>{0, 1, 3, 3};
            var expected = 2;

            // Act
            var actual = target.EditDistance(list1, list2).Item2;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
