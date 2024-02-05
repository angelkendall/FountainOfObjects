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
        // does the game need to make the fountain 
        // or should the world make the fountain 
        private Fountain _fountain;

        public World(Fountain fountain)
        {
            _fountain = fountain;

            InitialiseMap();
        }

        // Who decides what room type a room is
        // the world
        // or the room 
        private void InitialiseMap()
        {
            for (int row = 0; row < WorldSize; row++)
            {
                for (int col = 0; col < WorldSize; col++)
                {
                    if (row == 0 && col == 0)
                    {
                        Map[row, col] = new EntranceRoom(row, col, _fountain);
                    }
                    else if (row == 0 && col == 2)
                    {
                        Map[row, col] = new FountainRoom(row, col, _fountain);
                    } else
                    {
                        Map[row, col] = new EmptyRoom(row, col);
                    }

                }
            }
        }

        // Display each room's message
        public void Display()
        {
            for (int row = 0; row < WorldSize; row++)
            {
                for (int col = 0; col < WorldSize; col++)
                {
                    Map[row, col].DisplayCurrentRoom();
                    Map[row, col].DisplayRoomMessage();
                }
            }
        }


        // need to check if move is off the world's limits?

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