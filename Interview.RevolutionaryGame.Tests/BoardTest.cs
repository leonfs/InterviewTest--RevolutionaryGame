using NUnit.Framework;

namespace Interview.RevolutionaryGame.Tests
{
    [TestFixture]
    public class BoardTest
    {
        private Board _board;
        private BoardSize _boardSize;
        private Piece _piece;

        [SetUp]
        public void SetUp()
        {
            _boardSize = new BoardSize(5);
            _piece = new Piece(5, 5);
            _board = new Board(_boardSize, _piece, Direction.N);
        }

        [Test]
        public void MovePiece_OutOfBoardBoundariesDirectionNorth_SamePositionDirectionNorth()
        {
            _board.Move();
            var expectedOutput = new Output(5, 5, Direction.N); 
            Assert.AreEqual(expectedOutput, _board.Output());
        }

        [Test]
        public void MovePiece_WithinBoundariesDirectionSouth_ColumnDecrementedDirectionSouth()
        {
            _board = new Board(_boardSize, _piece, Direction.S);
            _board.Move();
            var expectedOutput = new Output(4, 5, Direction.S);
            Assert.AreEqual(expectedOutput, _board.Output());
        }

        [Test]
        public void TurnRight_FacingNorth_SamePositionFacingEast()
        {
            _board.TurnRight();
            var expectedOutput = new Output(5, 5, Direction.E);
            Assert.AreEqual(expectedOutput, _board.Output());
        }

        [Test]
        public void TurnLeft_FacingNorth_SamePositionFacingWest()
        {
            _board.TurnLeft();
            var expectedOutput = new Output(5, 5, Direction.W);
            Assert.AreEqual(expectedOutput, _board.Output());
        }



    }
}
