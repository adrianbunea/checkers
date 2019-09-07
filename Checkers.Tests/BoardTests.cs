using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Checkers.Tests
{
    [TestClass]
    public class BoardTests
    {
        [TestMethod]
        public void Board_NoParameters_StartsAsEmpty()
        {
            Board board = new Board();

            int[,] expectedSquares = new int[10, 10];
            int[,] actualSquares = board.Squares;

            CollectionAssert.AreEqual(expectedSquares, actualSquares);
        }

        [TestMethod]
        public void Initialize_NoParameters_SetsPiecesCorrectly()
        {
            Board board = new Board();
            int[,] expectedSquares = new int[10, 10] 
            {
                { 0, -1, 0, -1, 0, -1, 0, -1, 0, -1 },
                { -1, 0, -1, 0, -1, 0, -1, 0, -1, 0 },
                { 0, -1, 0, -1, 0, -1, 0, -1, 0, -1 },
                { -1, 0, -1, 0, -1, 0, -1, 0, -1, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 },
                { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 },
                { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 },
                { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 }
            };

            board.Initialize();
            int[,] actualSquares = board.Squares;

            CollectionAssert.AreEqual(expectedSquares, actualSquares);
        }
    }
}
