using System.Collections.Generic;
using Interview.RevolutionaryGame.Commands;

namespace Interview.RevolutionaryGame
{
    public class Player : IPlayer
    {

        public void Play(BoardCommand command)
        {
            command.Execute();
        }

        public void Play(List<BoardCommand> commands)
        {
            foreach (var boardCommand in commands)
            {
                Play(boardCommand);
            }
        }
    }
}
