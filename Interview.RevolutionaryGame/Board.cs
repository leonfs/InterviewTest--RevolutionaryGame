namespace Interview.RevolutionaryGame
{
    public class Board
    {
        private Direction _direction { get; set; }
        private BoardSize _size { get; set; }
        private Piece _piece { get; set; }


        public Board(BoardSize size, Piece piece, Direction direction)
        {
            this._piece = piece;
            this._size = size;
            this._direction = direction;
        }

        public void Move()
        {
            var movedPiece = _piece.Move(_direction);
            
            if (IsWithinBoundaries(movedPiece))
            {
                this._piece = movedPiece;
            }
        }

        public void TurnLeft()
        {
            switch (_direction)
            {
                case Direction.N:
                    _direction = Direction.W;
                    break;
                case Direction.W:
                    _direction = Direction.S;
                    break;
                case Direction.S:
                    _direction = Direction.E;
                    break;
                case Direction.E:
                    _direction = Direction.N;
                    break;
            }

        }

        public void TurnRight()
        {

            switch (_direction)
            {
                case Direction.N:
                    _direction = Direction.E;
                    break;
                case Direction.E:
                    _direction = Direction.S;
                    break;
                case Direction.S:
                    _direction = Direction.W;
                    break;
                case Direction.W:
                    _direction = Direction.N;
                    break;
            }
        }


        public Output Output()
        {
            return new Output(_piece.Column, _piece.Row, _direction);
        }

        internal bool IsWithinBoundaries(Piece piece)
        {
            return _size.IsWithinBoundaries(piece.Column, piece.Row);
        }
    }


}
