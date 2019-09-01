using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    public class Board
    {
        public int[,] squares;

        public Board()
        {
            squares = new int[10, 10];
        }

        public void Initialize()
        {
            SetBlackPieces();
            SetWhitePieces();
        }

        private void SetBlackPieces()
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 10; j++)
                {
                    squares[i, j] = -(i + j) % 2;
                }
        }
        private void SetWhitePieces()
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 10; j++)
                {
                    squares[i+6, j] = (i + j) % 2;
                }
        }
    }
}
