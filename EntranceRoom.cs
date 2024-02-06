using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FountainOfObjects
{
    public class EntranceRoom: Room
    {
        // Get the fountain object reference 
        private readonly Fountain _fountain;


        public EntranceRoom(int row, int col, Fountain fountain) : base(row, col, RoomType.Entrance)
        {
            _fountain = fountain;
        }

        // Displays one of two messages depending on whether the fountain is activated or not 
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

        // check if fountain is activated or not 
    }
}
