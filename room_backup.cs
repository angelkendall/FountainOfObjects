/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FountainOfObjects
{
    public class Room
    {
        // each room has a type 
        public RoomType Type { get; private set; }
        private readonly int _row;
        private readonly int _col;

        // each room has possible actions and messages depending on their type 
        public Room(int row, int column)
        {
            //Type = roomType;
            _row = row;
            _col = column;
            SetRoomType();
        }


        // Get a row and column and display that room location 
        // to the user 
        *//*        public void DisplayMessage()
                {
                    Console.WriteLine($"You are in room ({_row},{_col}). Room type: {Type}");
                }*//*

        public void DisplayCurrentRoom()
        {
            Console.WriteLine($"You are in the room at (Row={_row}, Column={_col}).");
        }


        // who decides what room type a room is
        private void SetRoomType()
        {
            if (_row == 0 & _col == 0)
            {
                Type = RoomType.Entrance;
            }
            else if (_row == 0 & _col == 2)
            {
                Type = RoomType.Fountain;
            }
            else
            {
                Type = RoomType.Empty;
            }
        }

        // this won't work because the message might change depending on whether the 
        // fountain has been activated etc
        *//*        private string RoomMessage(RoomType type) => type switch
                {
                    RoomType.Entrance => "You are in the entrance",
                    RoomType.Empty => ""
                    _ => throw new ArgumentOutOfRangeException(nameof(type), $"Not expected direction value: {type}"),
                };*//*
    }

    public enum RoomType
    {
        Empty,
        Entrance,
        Fountain,
        Pit
    }
}
*/