namespace FountainOfObjects
{
    public class Game
    {
        private readonly Fountain _fountain;
        private readonly World _world;
        private readonly Player _player;

        private bool _win = false;

        public Game()
        {
            _fountain = new Fountain();
            _world = new World(_fountain);
            _player = new Player(_fountain);
        }

        public void Run()
        {
            Console.WriteLine("THE FOUNTAIN OF OBJECTS");

            while (!_win)
            {
                DisplayCurrentRoom();
                ICommand command = GetCommand();
                command.Execute(_player);
                _win = CheckWin();
            }

            DisplayCurrentRoom();
            Console.WriteLine("You win!");

        }

        private void DisplayCurrentRoom()
        {
            string line = new('-', 100);
            Console.WriteLine(line);
            Console.WriteLine($"You are in the room at: (Row={_player.CurrentRow}, Column={_player.CurrentColumn}).");
            _world.Map[_player.CurrentRow, _player.CurrentColumn].DisplayRoomMessage();
        }

        private bool CheckWin()
        {
            return _fountain.State == FountainState.On && _world.Map[_player.CurrentRow, _player.CurrentColumn].RoomType == RoomType.Entrance;

        }

        ICommand GetCommand()
        {
            ICommand command = Player.GetInput() switch
            {
                "move east" => new CommandEast(),
                "move north" => new CommandNorth(),
                "move south" => new CommandSouth(),
                "move west" => new CommandWest(),
                "enable fountain" => new CommandFountain(),
                _ => throw new InvalidOperationException("Unrecognised command")
            };

            return command;
        }

    }
}
