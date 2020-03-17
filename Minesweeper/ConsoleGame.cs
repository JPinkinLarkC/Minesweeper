using System;
using System.Collections.Generic;
using System.Text;

namespace Minesweeper
{
    class ConsoleGame <T>: Game <T> where T : ICell
    {
        public ConsoleGame(int w, int h, int minas) : base (w, h, minas)
        {

        }
    }
}
