using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Checkers
{
    public class BoardUI : Panel
    {
        public SquareUI[,] Squares;

        public BoardUI(int size)
        {
            // TODO: Implement Guard Clause class
            if (size < 0)
            {
                throw new ArgumentException("Size cannot be negative.");
            }

            this.Size = new Size(size, size);
            this.Squares = new SquareUI[10, 10];
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    Squares[i, j] = new SquareUI(i, j, this.Height);
                    this.Controls.Add(Squares[i, j]);
                }
        }
    }
}
