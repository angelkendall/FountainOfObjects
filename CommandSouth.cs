namespace FountainOfObjects
{
    public class CommandSouth : ICommand
    {
        public void Execute(Player player)
        {
            if (World.CheckMoveInRange(player.CurrentRow + 1))
            {
                player.CurrentRow += 1;
            }
        }
    }
}
