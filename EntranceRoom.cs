namespace FountainOfObjects
{
    public class EntranceRoom(Fountain fountain) : Room(RoomType.Entrance)
    {
        private readonly Fountain _fountain = fountain;

        public override void DisplayRoomMessage()
        {
            if (_fountain.State == FountainState.Off)
            {
                Console.WriteLine("You see light coming from the cavern entrance.");
            }
            else
            {
                Console.WriteLine("The Fountain of Objects has been reactivated, and you have escaped with your life!");
            }
        }
    }
}
