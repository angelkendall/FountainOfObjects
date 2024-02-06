using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FountainOfObjects
{
    public class Player
    {

        private readonly Fountain _fountain;

        // current position?
        // current row?
        // current col

        // start in entrance
        public int CurrentRow { get; set; } = 0;
        public int CurrentColumn { get; set; } = 0;

        public Player(Fountain fountain) 
        { 
            _fountain = fountain;
        }

        // get player input 
        // player needs to know what room they're in 
        // player input is words 

        public void ChangeFountainStatus()
        {
            _fountain.State = _fountain.State == FountainState.On ? FountainState.Off : FountainState.On;
        }

        public enum Direction
        {
            North,
            West,
            South,
            East
        }


    }
}
