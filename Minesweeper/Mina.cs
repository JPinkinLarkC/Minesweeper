using System;
using System.Collections.Generic;
using System.Text;

namespace Minesweeper
{
    class Mina : ICell
    {
        private int x;
        private int y;

        private Celda.Status status;

        public int GetValue()
        {
            throw new NotImplementedException();
        }

        public bool IsHidden()
        {
            throw new NotImplementedException();
        }

        public void LeftClick()
        {
            throw new NotImplementedException();
        }

        public void RightClick()
        {
            throw new NotImplementedException();
        }
        public Celda.Status GetStatus()
        {
            return status;
        }
    }
}
