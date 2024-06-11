using NUnit.Framework;
using StringSorter.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSorter.StringSorterUnitTest
{
    [TestFixture]
    public class SortModelTests
    {
        [Test]
        public void SortModel_CanGetAndSetInputString()
        {
            // Arrange
            var model = new SortModel();
            string expected = "befdac";

            // Act
            model.InputString = expected;
            string result = model.InputString;

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SortModel_CanGetAndSetSortedString()
        {
            // Arrange
            var model = new SortModel();
            string expected = "abcdef";

            // Act
            model.SortedString = expected;
            string result = model.SortedString;

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
