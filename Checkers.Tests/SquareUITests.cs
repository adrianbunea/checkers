using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace Checkers.Tests
{
    [TestClass]
    public class SquareUITests
    {
        [TestMethod]
        [DataRow(0, 0, 1000,   0,   0)]
        [DataRow(1, 4, 1000, 100, 400)]
        [DataRow(6, 3,  500, 300, 150)]
        [DataRow(9, 9,  500, 450, 450)]
        public void SquareUI_WithPositiveBoardIndexesAndBoardUISize_HasRightLocation(int row, int column, int boardUISize, int expectedY, int expectedX)
        {
            SquareUI squareUI = new SquareUI(row, column, boardUISize);

            Point expectedPosition = new Point(expectedX, expectedY);
            Point actualPosition = squareUI.Location;

            Assert.AreEqual(expectedPosition, actualPosition);
        }

        [TestMethod]
        [DataRow(0, 0,  250,  25,  25)]
        [DataRow(0, 0,  500,  50,  50)]
        [DataRow(0, 0, 1000, 100, 100)]
        [DataRow(0, 0, 2000, 200, 200)]
        public void SquareUI_WithPositiveBoardSize_HasRightSize(int row, int column, int boardUISize, int expectedWidth, int expectedHeight)
        {
            SquareUI squareUI = new SquareUI(row, column, boardUISize);

            Size expectedSize = new Size(expectedWidth, expectedHeight);
            Size actualSize = squareUI.Size;

            Assert.AreEqual(expectedSize, actualSize);
        }

        [TestMethod]
        [DataRow(0, 0, 0)]
        [DataRow(9, 9, 0)]
        [DataRow(4, 1, 1)]
        [DataRow(5, 4, 1)]
        public void SquareUI_WithPositiveIndexes_HasRightBackgroundColor(int row, int column, int colorIndex)
        {
            Color[] squareColors = new Color[]
            {
                Color.White,
                Color.DimGray
            };
            SquareUI squareUI = new SquareUI(row, column, 0);

            Color expectedColor = squareColors[colorIndex];
            Color actualColor = squareUI.BackColor;

            Assert.AreEqual(expectedColor, actualColor);
        }

        [TestMethod]
        [DataRow(-1,  0)]
        [DataRow( 0, -1)]
        [DataRow(-1, -1)]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void SquareUI_WithNegativeIndexes_ThrowsIndexOutOfRangeException(int row, int column)
        {
            SquareUI squareUI = new SquareUI(row, column, 0);
        }

        [TestMethod]
        [DataRow(10,  0)]
        [DataRow( 0, 10)]
        [DataRow(10, 10)]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void SquareUI_WithIndexesLargerThanMaximumLimit_ThrowsIndexOutOfRangeException(int row, int column)
        {
            SquareUI squareUI = new SquareUI(row, column, 0);
        }
    }
}
