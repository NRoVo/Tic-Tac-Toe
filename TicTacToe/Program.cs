using System;

namespace TicTacToe
{
    public static class Program
    {
        private static void Main()
        {
            var game = new Game();
            while (!game.IsOver)
            {
                game.RenderBoard();
                game.NextMove();
            }

            game.RenderBoard();
            game.RenderResults();
            Console.ReadKey();
        }
    }
}
