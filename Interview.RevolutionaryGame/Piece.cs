using System;

namespace Interview.RevolutionaryGame
{
    public class Piece 
    {
        public int Column { get; private set; }
        public int Row { get; private set; }

        public Piece(int column, int row)
        {
            if (column < 0)
                throw new ArgumentOutOfRangeException("column", "Column can't be lower than zero.");
            if (row < 0)
                throw new ArgumentOutOfRangeException("row", "Row can't be lower than zero");

            Column = column;
            Row = row;
        }

        public Piece Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.N:
                    return MoveNorth();
                case Direction.E:
                    return MoveEast();
                case Direction.S:
                    return MoveSouth();
                case Direction.W:
                    return MoveWest();
                default:
                    throw new ApplicationException("Invalid direction.");
            }
        }

        private Piece MoveNorth()
        {
            return MoveVertically(1);
        }

        private Piece MoveSouth()
        {
            return MoveVertically(-1);
        }

        private Piece MoveVertically(int steps)
        {
            return new Piece(Column + steps, Row);
        }

        private Piece MoveEast()
        {
            return MoveHorizontally(1);
        }

        private Piece MoveWest()
        {
            return MoveHorizontally(-1);
        }

        private Piece MoveHorizontally(int steps)
        {
            return new Piece(Column, Row + steps);
        }

        protected bool Equals(Piece other)
        {
            return Column == other.Column && Row == other.Row;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Piece)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Column * 397) ^ Row;
            }
        }


    }
}
