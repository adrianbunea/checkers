﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace Checkers
{
    public class SquareUI : PictureBox
    {
        readonly Color LIGHT_COLOR = Color.White;
        readonly Color DARK_COLOR = Color.DimGray;

        readonly Dictionary<int, Image> PIECE_IMAGES = new Dictionary<int, Image>
        {
            { -1, Properties.Resources.BlackPiece },
            {  0, null },
            {  1, Properties.Resources.WhitePiece }
        };

        public SquareUI(int row, int column, int boardUISize)
        {
            if (row < 0 || column < 0)
            {
                throw new IndexOutOfRangeException("Row/Column cannot be negative.");
            }

            if (row > 9 || column > 9)
            {
                throw new IndexOutOfRangeException("Row/Column cannot be bigger than the last column index.");
            }

            this.Left = column * (boardUISize / 10);
            this.Top = row * (boardUISize / 10);
            this.Size = new Size(boardUISize / 10, boardUISize / 10);
            this.BackColor = ((row + column) % 2 == 0 ? LIGHT_COLOR : DARK_COLOR);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Padding = new Padding(4);
        }

        public void Redraw(int piece)
        {
            this.Image = PIECE_IMAGES[piece];
        }
    }
}
