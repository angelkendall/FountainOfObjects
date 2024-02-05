using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FountainOfObjects
{

    // This shouldn't even need to exist? Maybe an abstract method isn't the best way 
    // but a room must display a message, unless its an empty room 
    public class EmptyRoom(int row, int col) : Room(row, col)
    {

        // Empty rooms don't display a message though
        public override void DisplayRoomMessage()
        {

        }
    }
}
