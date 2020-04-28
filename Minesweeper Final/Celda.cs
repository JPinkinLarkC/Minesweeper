using System;
using System.Collections.Generic;
using System.Text;

namespace Minesweeper
{
    public class Celda : ICell
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

        public Celda()
        {
            this.status = Status.HIDDEN;
        }

        public int GetValue()
        {
            return this.valor;
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
        public Status GetStatus()
        {
            return this.status;
        }
    }
}
