namespace Interview.RevolutionaryGame
{
    public class Output
    {

        public int Column { get; private set; }
        public int Row { get; private set; }
        public Direction Direction { get; private set; }

        public Output(int column, int row, Direction direction)
        {
            this.Column = column;
            this.Row = row;
            this.Direction = direction;
        }

        protected bool Equals(Output other)
        {
            return Column == other.Column && Row == other.Row && Direction.Equals(other.Direction);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Output)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Column;
                hashCode = (hashCode * 397) ^ Row;
                hashCode = (hashCode * 397) ^ Direction.GetHashCode();
                return hashCode;
            }
        }

        public override string ToString()
        { 
            return string.Format("{0} {1} {2}", Column, Row, Direction);
        }
    }
}
