namespace Interview.RevolutionaryGame.Commands
{
    public class TurnLeftCommand : BoardCommand
    {
        public TurnLeftCommand(Board board) : base(board)
        {
        }

        public override void Execute()
        {
            _board.TurnLeft(); 
        }
    }
}
