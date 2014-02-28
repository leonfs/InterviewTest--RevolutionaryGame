using System.Collections.Generic;
using Interview.RevolutionaryGame.Commands;
using NUnit.Framework;

namespace Interview.RevolutionaryGame.Tests
{
    [TestFixture]
    public class PlayerTest
    {
        private IPlayer _player;
        private Board _board;

        [SetUp]
        public void SetUp()
        {
            _player = new Player();
            _board = new Board(new BoardSize(5), new Piece(0, 0), Direction.N );

        }

        [Test]
        public void Play_Move_OneZeroNorthOutput()
        {
            var expectedOutput = new Output(1, 0, Direction.N);
            Play(MoveCommand(), expectedOutput);
        }

        [Test]
        public void Play_TurnLeft_ZeroZeroWestOutput()
        {
            var expectedOutput = new Output(0, 0, Direction.W);
            Play(TurnLeftCommand(), expectedOutput);
        }

        [Test]
        public void Play_TurnRight_ZeroZeroEastOutput()
        {
            var expectedOutput = new Output(0, 0, Direction.E);
            Play(TurnRightCommand(), expectedOutput);
        }

         [Test]
        public void Play_MRMLMRM_22E()
         {
             //Following one of the PDF examples
             var commandsInput = new List<BoardCommand>();
             commandsInput.Add(MoveCommand());
             commandsInput.Add(TurnRightCommand());
             commandsInput.Add(MoveCommand());
             commandsInput.Add(TurnLeftCommand());
             commandsInput.Add(MoveCommand());
             commandsInput.Add(TurnRightCommand());
             commandsInput.Add(MoveCommand());

             _player.Play(commandsInput);

             var expectedOutput = new Output(2, 2, Direction.E);
             Assert.AreEqual(expectedOutput, _board.Output());
         }

        [Test]
        private void Play(BoardCommand command, Output expectedOutput)
        {
            _player.Play(command);
            Assert.AreEqual(expectedOutput, _board.Output());
        }

        private BoardCommand MoveCommand()
        {
            return new MoveCommand(_board);
        }

        private BoardCommand TurnLeftCommand()
        {
            return new TurnLeftCommand(_board);
        }

        private BoardCommand TurnRightCommand()
        {
            return new TurnRightCommand(_board);
        }

       
       
    }
}
