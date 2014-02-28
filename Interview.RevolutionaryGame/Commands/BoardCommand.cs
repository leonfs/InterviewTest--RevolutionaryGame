namespace Interview.RevolutionaryGame.Commands
{
    public abstract class BoardCommand
    {
        protected Board _board;

        protected BoardCommand(Board board)
        {
            this._board = board;
        }

        public abstract void Execute();




    }
}
