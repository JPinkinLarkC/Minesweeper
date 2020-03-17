using System;
using System.Collections.Generic;
using System.Text;

namespace Minesweeper
{
    class Celda : ICell
    {
        public enum Status
        {
            HIDDEN,
            SHOWN,
            FLAG, 
            QUESTION
        }

        private int valor;
        private int x;
        private int y;

        private Status status;

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
    }
}
