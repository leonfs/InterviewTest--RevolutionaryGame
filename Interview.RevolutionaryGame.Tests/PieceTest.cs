using System;
using NUnit.Framework;

namespace Interview.RevolutionaryGame.Tests
{
    [TestFixture]
    public class PieceTest
    {
        private Piece _zeroZeroPiece;

        [SetUp]
        public void SetUp()
        {
            _zeroZeroPiece = new Piece(0, 0);
        }

        [Test]
        public void Move_MovedToEast_ZeroOne()
        {
            var movedPiece = _zeroZeroPiece.Move(Direction.E);
            var expectedPiece = new Piece(0, 1);
            Assert.AreEqual(expectedPiece, movedPiece);
        }

        [Test]
        public void Move_MovedToNorth_OneZero()
        {
            var movedPiece = _zeroZeroPiece.Move(Direction.N);
            var expectedPiece = new Piece(1, 0);
            Assert.AreEqual(expectedPiece, movedPiece);
        }


        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Move_MoveSouthInPositionZeroZero_ExceptionThrown()
        {
            _zeroZeroPiece.Move(Direction.S);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Move_MoveWestInPositionZeroZero_ExceptionThrown()
        {
            _zeroZeroPiece.Move(Direction.W);
        }

        




        
    }
}
