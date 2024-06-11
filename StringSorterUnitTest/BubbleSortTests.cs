using NUnit.Framework;
using StringSorter.Scripts;
using StringSorter.Scripts.Sortables;


namespace StringSorter.StringSorterUnitTest
{
    [TestFixture]
    public class BubbleSortTests
    {
        [Test]
        public void BubbleSort_SortsStringCorrectly()
        {
            // Arrange
            ISortable sorter = new BubbleSort();
            string input = "befdac";
            string expected = "abcdef";

            // Act
            string result = sorter.SortBy(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

    }
}