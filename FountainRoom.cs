using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FountainOfObjects
{

    // should the fountain live inside the fountain room
    public class FountainRoom : Room
    {
        private readonly Fountain _fountain;

        public FountainRoom(int row, int col, Fountain fountain) : base (row, col)
        {
            _fountain = fountain;
        }

        public override void DisplayRoomMessage()
        {
            if (_fountain.State == FountainState.Off)
            {
                Console.WriteLine("You hear water dripping in this room. The Fountain of Objects is here!");
            } else
            {
                Console.WriteLine("You hear the rushing waters from the Fountain of Objects. It has been reactivated!");
            }

        }

        public void DisplayFountainMessage()
        {
            Console.WriteLine($"The fountain is: {_fountain.State}");
        }
    }
}
