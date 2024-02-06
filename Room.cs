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
        // private readonly int _row;
        //private readonly int _col;


        // set the row and column for the room in world 
        // allow the player to get the current room??

        // should i use init?
        public int Row { get; init; }
        public int Column { get; init; }
        public RoomType RoomType { get; init; }

        // each room has possible actions and messages depending on their type 
        public Room(int row, int column, RoomType roomType)
        {
            Row = row;
            Column = column;
            RoomType = roomType;
        }

        public void DisplayCurrentRoom()
        {
            Console.WriteLine($"You are in the room at (Row={Row}, Column={Column}).");
        }

        public virtual void DisplayRoomMessage() {}

        // game could check if the room is the entrance and the fountain is on
        // but what if the win condition changes 
    }

    public enum RoomType
    {
        Empty,
        Fountain,
        Entrance
    }
}
