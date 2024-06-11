using NUnit.Framework;
using StringSorter.Scripts;
using StringSorter.Scripts.Sortables;

namespace StringSorter.StringSorterUnitTest
{
    [TestFixture]
    public class QuickSortTests
    {
        [Test]
        public void QuickSort_SortsStringCorrectly()
        {
            // Arrange
            ISortable sorter = new QuickSort();
            string input = "befdac";
            string expected = "abcdef";

            // Act
            string result = sorter.SortBy(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
