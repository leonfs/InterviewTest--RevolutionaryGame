namespace Interview.RevolutionaryGame.Commands
{
    public class MoveCommand : BoardCommand
    {
        public MoveCommand(Board board) : base(board)
        {
            
        }

        public override void Execute()
        {
            _board.Move();
        }
    }
}
