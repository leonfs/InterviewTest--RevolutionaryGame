namespace Interview.RevolutionaryGame
{
    public class BoardSize
    {
        private int _sizeNumber { get; set; }

        public BoardSize(int sizeNumber)
        {
            _sizeNumber = sizeNumber;
        }

        public bool IsWithinBoundaries(int column, int row)
        {
            if (column >= 0 && column < _sizeNumber && row >= 0 && row <= _sizeNumber)
                return true; 

            return false;
        }

    }
}
