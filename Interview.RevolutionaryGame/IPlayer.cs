using System.Collections.Generic;
using Interview.RevolutionaryGame.Commands;

namespace Interview.RevolutionaryGame
{
    public interface IPlayer
    {
        void Play(BoardCommand command);

        void Play(List<BoardCommand> commands);
    }
}
