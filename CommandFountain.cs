namespace FountainOfObjects
{
    public class CommandFountain : ICommand
    {
        public void Execute(Player player)
        {
            player.ChangeFountainStatus();
        }
    }
}
