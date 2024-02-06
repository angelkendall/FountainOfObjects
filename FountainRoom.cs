namespace FountainOfObjects
{
    public class FountainRoom(Fountain fountain) : Room(RoomType.Fountain)
    {
        private readonly Fountain _fountain = fountain;

        public override void DisplayRoomMessage()
        {
            if (_fountain.State == FountainState.Off)
            {
                Console.WriteLine("You hear water dripping in this room. The Fountain of Objects is here!");
            } else
            {
                Console.WriteLine("You hear the rushing waters from the Fountain of Objects. It has been reactivated!");
            }

        }
    }
}
