using System;
using System.Collections.Generic;
using System.Text;

namespace Minesweeper
{
    class ConsoleGame<T> : Game<T> where T : ICell, new()
    {
        private char hiddenSymbol;
        private char mineSymbol;
        private char flagSymbol;

        public ConsoleGame(int w, int h, int minas) : base(w, h, minas)
        {
            this.hiddenSymbol = (char)9632;
            this.mineSymbol = '*';
            this.flagSymbol = '#';
            this.ShowGrid();
        }
        public void ShowGrid()
        {
            Console.Write(("").PadLeft(4));
            for (uint i = 0; i < this.Width; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine((char)(65 + i) + "  ");
            }
            Console.WriteLine();
            string printingValue;
            for (uint i = 0; i < this.Height; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(((i + 1) + "  ").PadLeft(4));
                Console.ForegroundColor = ConsoleColor.White;
                for (int j = 0; j < this.Width; j++)
                {

                    switch (this.celdas[j, i].GetStatus())
                    {
                        case Celda.Status.SHOWN:
                            if (this.celdas[j, i] is Mina)
                            {
                                printingValue = this.mineSymbol.ToString();
                            }
                            else
                            {
                                printingValue = "" + this.celdas[j, i].GetValue();
                            }
                            break;
                        case Celda.Status.FLAG:
                            printingValue = "" + this.flagSymbol;
                            break;
                        default:
                            printingValue = "" + this.hiddenSymbol;
                            break;
                    }
                    Console.Write(printingValue + " ");
                }
            }
        }
    }
}
    
