using System;

namespace Minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleGame<Celda> game = new ConsoleGame<Celda>(6, 7, 10);
            Console.ReadKey();
        }
    }
}
