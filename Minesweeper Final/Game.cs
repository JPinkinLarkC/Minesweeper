using System;
using System.Collections.Generic;
using System.Text;

namespace Minesweeper
{
    class Game <T> where T :  ICell, new()
    {

            protected int tiempo;
            protected int TotalMinas;

            protected int FlagCounter;
            protected int MineCounter;

            protected int Width;
            protected int Height;            
            protected ICell[,] celdas;


            public Game(int Widht, int Height, int minas)
            {
                this.Width = Widht;
                this.Height = Height;
                this.TotalMinas = minas;

                this.celdas = new ICell[Widht, Height];
                for (int i = 0; i < this.Width; i++)
                {
                    for (uint j = 0; j < this.Height; j++)
                    {
                    this.celdas[i, j] = new T();
                    }
                }

            }
    }
}