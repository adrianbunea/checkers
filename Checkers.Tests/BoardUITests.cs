using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.Windows.Forms;

namespace Checkers.Tests
{
    [TestClass]
    public class BoardUITests
    {
        [TestMethod]
        [DataRow(200, 200, 200)]
        [DataRow(400, 400, 400)]
        [DataRow(100, 100, 100)]
        [DataRow(  0,   0,   0)]
        public void BoardUI_WithPositiveSizeParameter_HasCorrectSizes(int size, int expectedWidth, int expectedHeight)
        {
            BoardUI boardUI = new BoardUI(size);

            Size expectedSize = new Size(expectedWidth, expectedHeight);
            Size actualSize = boardUI.Size;

            Assert.AreEqual(expectedSize, actualSize);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BoardUI_WithNegativeSizeParameter_ThrowsArgumentException()
        {
            new BoardUI(-100);
        }

        [TestMethod]
        public void BoardUI_WithSizeParameter_CreatesColumnsWithAlternatingColors()
        {
            BoardUI boardUI = new BoardUI(200);

            for (int row = 0; row < 10; row++)
                for (int column = 0; column < 9; column++)
                {
                    SquareUI currentSquare = boardUI.Squares[row, column];
                    SquareUI nextSquare = boardUI.Squares[row, column + 1];

                    if (currentSquare.BackColor == nextSquare.BackColor)
                    {
                        Assert.Fail();
                    }
                }
        }

        [TestMethod]
        public void BoardUI_WithSizeParameter_CreatesRowsWithAlternatingColors()
        {
            BoardUI boardUI = new BoardUI(200);

            for (int column = 0; column < 10; column++)
                for (int row = 0; row < 9; row++)
                {
                    SquareUI currentSquare = boardUI.Squares[row, column];
                    SquareUI nextSquare = boardUI.Squares[row + 1, column];

                    if (currentSquare.BackColor == nextSquare.BackColor)
                    {
                        Assert.Fail();
                    }
                }
        }

        [TestMethod]
        public void BoardUI_WithSizeParameter_ContainsOnlyTwoSquareColors()
        {
            // It might seem like a useless test, but with the alternating color tests
            // this ensures the board actually has the black/white checkered pattern of a proper board

            BoardUI boardUI = new BoardUI(200);
            Color[] squareColors = new Color[]
            {
                Color.White,
                Color.DimGray
            };

            foreach(SquareUI square in boardUI.Squares)
            {
                if (!Array.Exists(squareColors, color => color == square.BackColor))
                {
                    Assert.Fail();
                }
            }
        }
    }
}
