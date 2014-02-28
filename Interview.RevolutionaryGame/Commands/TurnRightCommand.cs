namespace Interview.RevolutionaryGame.Commands
{
    public class TurnRightCommand : BoardCommand
    {
        public TurnRightCommand(Board board) : base(board)
        {
        }

        public override void Execute()
        {
            _board.TurnRight();
        }
    }
}
