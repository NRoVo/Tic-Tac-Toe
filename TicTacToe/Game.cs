using System;

namespace TicTacToe
{
    public class Game
    {
        private readonly Board _board;
        private readonly WinChecker _winChecker;
        private readonly Renderer _renderer;
        private readonly Player _x;
        private readonly Player _o;

        public Game()
        {
            _board = new Board();
            _winChecker = new WinChecker(_board);
            _renderer = new Renderer(_board);
            _x = new Player();
            _o = new Player();
        }

        public bool IsOver => _winChecker.IsDraw() || _winChecker.GetWinner() != State.Undecided;

        public void NextMove()
        {
            var userInput = Console.ReadLine();
            var isNumeric = Int32.TryParse(userInput, out var position);
            if (isNumeric)
            {
                if (position > 0 && position < 10)
                {
                    var nextMove = _board.NextTurn == State.X ? _x.GetPosition(position) : _o.GetPosition(position);
                    if (!_board.SetState(nextMove, _board.NextTurn))
                    {
                        Console.WriteLine("That is not a legal move.");
                    }
                }
                else
                {
                    Console.WriteLine(
                        "Please enter a number from 1 to 9 to specify desired position using numpad as representation of a grid.");
                }
            }
            else
            {
                Console.WriteLine("Your entry was not a number!");
            }
        }

        public void RenderBoard()
        {
            _renderer.Render();
        }

        public void RenderResults()
        {
            _renderer.RenderResults(_winChecker.GetWinner());
        }
    }
}