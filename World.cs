namespace FountainOfObjects
{
    public class World
    {
        public Room[,] Map { get; } = new Room[WorldSize, WorldSize];

        public static int WorldSize { get; } = 4;

        private readonly Fountain _fountain;

        public World(Fountain fountain)
        {
            _fountain = fountain;

            InitialiseMap();
        }

        // Place different rooms at specific places,
        // and make all other rooms empty
        private void InitialiseMap()
        {
            for (int row = 0; row < WorldSize; row++)
            {
                for (int col = 0; col < WorldSize; col++)
                {

                    if (row == 0 && col == 0)
                    {
                        Map[row, col] = new EntranceRoom(_fountain);
                    }
                    else if (row == 0 && col == 2)
                    {
                        Map[row, col] = new FountainRoom(_fountain);
                    }
                    else
                    {
                        Map[row, col] = new Room(RoomType.Empty);
                    }

                }
            }
        }

        public static bool CheckMoveInRange(int move)
        {
            if (move < 0 || move > WorldSize || move == WorldSize)
            {
                Console.WriteLine("You are trying to move off the map.\n");
                return false;
            }

            return true;
        }

    }
}
