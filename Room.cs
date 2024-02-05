using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FountainOfObjects
{
    public abstract class Room
    {
        // each room has a type 
       // private readonly int _row;
        //private readonly int _col;


        // set the row and column for the room in world 
        // allow the player to get the current room??
        public int Row { get; init; }
        public int Column { get; init; }

        // each room has possible actions and messages depending on their type 
        public Room(int row, int column)
        {
            //Type = roomType;
            Row = row;
            Column = column;
        }

        public void DisplayCurrentRoom()
        {
            Console.WriteLine($"You are in the room at (Row={Row}, Column={Column}).");
        }

        public abstract void DisplayRoomMessage();

    }

}
