namespace FountainOfObjects
{
    public class Room(RoomType roomType)
    {
        public RoomType RoomType { get; init; } = roomType;

        public virtual void DisplayRoomMessage() { }

    }

    public enum RoomType
    {
        Empty,
        Fountain,
        Entrance
    }
}
