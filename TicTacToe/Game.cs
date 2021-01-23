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
            var nextMove = _board.NextTurn == State.X
                ? _x.GetPosition()
                : _o.GetPosition();
            if (!_board.SetState(nextMove, _board.NextTurn))
            {
                Console.WriteLine("That is not a legal move.");
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