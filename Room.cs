using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FountainOfObjects
{
    public class Room
    {
        // each room has a type 
        public RoomType Type { get; init; }
        private readonly string? _roomMessage;
        // room needs to know it's own coords in the world map?

        // each room has possible actions and messages depending on their type 

        public void DisplayMessage()
        {
            Console.WriteLine($"You are in room {0}");
        }

        // this won't work because the message might change depending on whether the 
        // fountain has been activated etc
/*        private string RoomMessage(RoomType type) => type switch
        {
            RoomType.Entrance => "You are in the entrance",
            RoomType.Empty => ""
            _ => throw new ArgumentOutOfRangeException(nameof(type), $"Not expected direction value: {type}"),
        };*/
    }

    public enum RoomType
    {
        Empty,
        Entrance,
        Fountain,
        Pit
    }
}
