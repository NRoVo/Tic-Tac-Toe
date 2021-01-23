namespace TicTacToe
{
    public class WinChecker
    {
         private readonly Board _board;

        public WinChecker(Board board) => this._board = board;

        public State GetWinner()
        {
            if (CheckForWin(State.X))
            {
                return State.X;
            }

            if (CheckForWin(State.O))
            {
                return State.O;
            }

            return State.Undecided;
        }

        private bool CheckForWin(State player)
        {
            for (var row = 0; row < 3; row++)
            {
                if (AreAll(new[] {new Position(row, 0), new Position(row, 1), new Position(row, 2)},
                    player))
                {
                    return true;
                }
            }

            for (var column = 0; column < 3; column++)
            {
                if (AreAll(new[] {new Position(0, column), new Position(1, column), new Position(2, column)}, player))
                {
                    return true;
                }
            }

            if (AreAll(new[] {new Position(0, 0), new Position(1, 1), new Position(2, 2)}, player))
            {
                return true;
            }

            if (AreAll(new[] {new Position(2, 0), new Position(1, 1), new Position(0, 2)}, player))
            {
                return true;
            }

            return false;
        }

        private bool AreAll(Position[] positions, State state)
        {
            foreach (var position in positions)
            {
                if (_board.GetState(position) != state)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsDraw()
        {
            for (var row = 0; row < 3; row++)
            {
                for (var column = 0; column < 3; column++)
                {
                    if (_board.GetState(new Position(row, column)) == State.Undecided)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}