using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    public class Board
    {
        // TODO: Move constants into separate file
        // TODO: Implement a way to change the board size
        public int[,] Squares;

        public Board()
        {
            Squares = new int[10, 10];
            SetPieces();
        }

        public void SetPieces()
        {
            SetBlackPieces();
            SetWhitePieces();
        }

        private void SetBlackPieces()
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 10; j++)
                {
                    Squares[i, j] = -(i + j) % 2;
                }
        }
        private void SetWhitePieces()
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 10; j++)
                {
                    Squares[i+6, j] = (i + j) % 2;
                }
        }
    }
}
