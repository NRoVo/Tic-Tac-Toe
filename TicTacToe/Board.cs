namespace TicTacToe
{
    public class Board
    {
        private readonly State[,] _state;
        public State NextTurn { get; private set; }

        public Board()
        {
            _state = new State[3, 3];
            NextTurn = State.X;
        }

        public State GetState(Position position)
        {
            return _state[position.Row, position.Column];
        }

        public bool SetState(Position position, State newState)
        {
            if (newState != NextTurn)
            {
                return false;
            }

            if (_state[position.Row, position.Column] != State.Undecided)
            {
                return false;
            }

            _state[position.Row, position.Column] = newState;
            SwitchNextTurn();
            return true;
        }

        private void SwitchNextTurn()
        {
            NextTurn = NextTurn == State.X ? State.O : State.X;
        }
    }
}
