using System;

namespace TicTacToe
{
    public class Renderer
    {
        private readonly Board _board;

        public Renderer(Board board)
        {
            this._board = board;
        }

        public void Render()
        {
            var symbols = new char[3, 3];
            for (var row = 0; row < 3; row++)
            for (var column = 0; column < 3; column++)
            {
                symbols[row, column] = SymbolFor(_board.GetState(new Position(row, column)));
            }

            Console.WriteLine($" {symbols[0, 0]} | {symbols[0, 1]} | {symbols[0, 2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {symbols[1, 0]} | {symbols[1, 1]} | {symbols[1, 2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {symbols[2, 0]} | {symbols[2, 1]} | {symbols[2, 2]} ");
        }

        private char SymbolFor(State state)
        {
            switch (state)
            {
                case State.O: return 'O';
                case State.X: return 'X';
                default:      return ' ';
            }
        }

        public void RenderResults(State winner)
        {
            switch (winner)
            {
                case State.O:
                case State.X:
                    Console.WriteLine(SymbolFor(winner) + " Wins!");
                    break;
                case State.Undecided:
                    Console.WriteLine("Draw!");
                    break;
            }
        }
    }
}
