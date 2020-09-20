using Xunit;

namespace CourseraAlgsSanDiego.AlgorithmicToolbox.Week6
{
    public class Week6Task1MaximumAmountOfGoldTest
    {
        private Week6Task1MaximumAmountOfGold target = new Week6Task1MaximumAmountOfGold();

        [Fact]
        public void KnapsackWithoutRepetitions_SimpleTest1()
        {
            // Arrange
            var weight = 4;
            var items = new[] {1, 2, 3};
            var expected = 4;

            // Act
            var actual = target.KnapsackWithoutRepetitions(weight, items);

            // Asset
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void KnapsackWithoutRepetitions_Simpletest2()
        {
            // Arrange
            var weight = 10;
            var items = new[] {1, 4, 8};
            var expected = 9;

            // Act
            var actual = target.KnapsackWithoutRepetitions(weight, items);

            // Asset
            Assert.Equal(expected, actual);
        }
    }
}
