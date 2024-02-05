using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FountainOfObjects
{
    public class EntranceRoom: Room
    {
        private readonly Fountain _fountain;

        public EntranceRoom(int row, int col, Fountain fountain) : base(row, col)
        {
            _fountain = fountain;
        }

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
