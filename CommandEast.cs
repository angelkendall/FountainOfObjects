namespace FountainOfObjects
{
    public class CommandEast : ICommand
    {
        public void Execute(Player player) 
        {
            if (World.CheckMoveInRange(player.CurrentColumn+1))
            {
                player.CurrentColumn += 1;
            }

        }
    }
}
