namespace TicTacToe
{
    public class Player
    {
        public Position GetPosition(int position)
        {
            var deziredCoordinate = PositionForNumber(position);
            return deziredCoordinate;
        }

        private Position PositionForNumber(int position)
        {
            switch(position)
            {
                case 1:
                    return new Position(2, 0);
                case 2:
                    return new Position(2, 1);
                case 3:
                    return new Position(2, 2);
                case 4:
                    return new Position(1, 0);
                case 5:
                    return new Position(1, 1);
                case 6:
                    return new Position(1, 2);
                case 7:
                    return new Position(0, 0);
                case 8:
                    return new Position(0, 1);
                case 9:
                    return new Position(0, 2);
                default:
                    return null;
            }
        }
    }
}
