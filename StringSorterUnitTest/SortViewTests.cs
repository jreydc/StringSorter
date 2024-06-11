using NUnit.Framework;
using StringSorter.Scripts;
using StringSorter.Scripts.Utilities;

namespace StringSorter.StringSorterUnitTest
{
    [TestFixture]
    public class SortViewTests
    {
        private frmMain _view;

        [SetUp]
        public void SetUp() => _view = new frmMain();
        
        [Test]
        public void SortView_GetInputString_ReturnsCorrectValue()
        {
            // Arrange
            string expected = "befdac";
            _view.InputTextBox.Text = expected;

            // Act
            string result = _view.GetInputString();

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SortView_GetSelectedSortedType_ReturnsCorrectValue()
        {
            // Arrange
            string selectedSortType = "Bubble Sort";
            var expected = _view.SortTypeConverter(selectedSortType);
            
            // Act
            var result = _view.GetSelectedSortType();

            // Assert
            Assert.That(result, Is.EqualTo(selectedSortType));
        }

        [Test]
        public void SortView_DisplayResult_SetsLabelCorrectly()
        {
            // Arrange
            string sortedString = "abcdef";
            string selectedSortType = "Bubble Sort";
            SortType expectedSortType = _view.SortTypeConverter(selectedSortType);
            var result = $"Output: {expectedSortType}\n{sortedString}";

            // Act
            _view.DisplaySortedString(result);

            // Assert
            Assert.That(result,Is.EqualTo(_view.OutputLabel.Text));
        }

        [Test]
        public void SortView_TextBox_NullValidation()
        {
            // Arrange
            _view.InputTextBox.Text = null;
            var expected = _view.InputTextBox.Text;

            // Act
            var result = _view.InputTextBox.Text.NullOrEmpty();

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SortView_ComboBox_NullValidation()
        {
            // Arrange
            _view.SortTypeComboBox.SelectedItem = null;
            var expected = _view.SortTypeComboBox.SelectedItem;

            // Act
            var result = _view.SortTypeComboBox.SelectedText.NullOrEmpty();

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
