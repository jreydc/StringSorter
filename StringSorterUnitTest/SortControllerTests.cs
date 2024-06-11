using Moq;
using NUnit.Framework;
using StringSorter.Scripts;

namespace StringSorter.StringSorterUnitTest
{
    [TestFixture]
    public class SortControllerTests
    {
        private SortController _controller;
        private SortModel _model;
        private Mock<frmMain> _mockView;

        [SetUp]
        public void SetUp()
        {
            _model = new SortModel();
            _mockView = new Mock<frmMain>();
            _controller = new SortController(_model, _mockView.Object);
        }

        [Test]
        public void SortController_SortsStringCorrectly_BubbleSort()
        {
            // Arrange
            _mockView.Setup(v => v.GetInputString()).Returns("befdac");
            _mockView.Setup(v => v.GetSelectedSortType()).Returns(SortType.Bubble);

            // Act
            _controller.Sorted();

            // Assert
            _mockView.Verify(v => v.DisplaySortedString("abcdef"), Times.Once);
        }

        [Test]
        public void SortController_SortsStringCorrectly_QuickSort()
        {
            // Arrange
            _mockView.Setup(v => v.GetInputString()).Returns("befdac");
            _mockView.Setup(v => v.GetSelectedSortType()).Returns(SortType.Quick);

            // Act
            _controller.Sorted();

            // Assert
            _mockView.Verify(v => v.DisplaySortedString("abcdef"), Times.Once);
        }

        [Test]
        public void SortController_SortsStringCorrectly_MergeSort()
        {
            // Arrange
            _mockView.Setup(v => v.GetInputString()).Returns("befdac");
            _mockView.Setup(v => v.GetSelectedSortType()).Returns(SortType.Merge);

            // Act
            _controller.Sorted();

            // Assert
            _mockView.Verify(v => v.DisplaySortedString("abcdef"), Times.Once);
        }
    }
}
