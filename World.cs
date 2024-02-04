using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

/*
 * The game board is a 4x4 grid 
 * The player can't move off the game board 
 * The game board is never actually displayed to the user
 *  In the future, maybe it can be changed to being displayed as a grid 
 *  
 * How to track the current position in the board 
 * 
 * Different rooms on the board 
 *  Entry room
 *  Fountain room
 *  Future rooms (pit etc)
 *  
 *  
 */

namespace FountainOfObjects
{
    public class World
    {
        // map is a 2D array of (ints)
        // Maybe this should be a 2D array of rooms
        public Room[,] Map { get; } = new Room[4, 4];

        // Room size can be initialised by the game (small/med/large)
        public int WorldSize { get; init; } = 4;

        public void Display()
        {
            for (int row  = 0; row < WorldSize; row++)
            {
                for (int col = 0; col < WorldSize; col++)
                {
                    Console.Write($"({row},{col}) ");
                }
                Console.WriteLine();
            }
        }
    }
}

// should a room be an enum,
// an interace
// a base class

// each room has:
// a message
// possible valid actions (move, interact, attack, etc)
// a coordinate 

/*enum Room
{
    Empty,
    Entrance, 
    Fountain,
    Pit
}*/