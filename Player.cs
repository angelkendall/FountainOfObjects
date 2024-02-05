using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FountainOfObjects
{
    public class Player
    {

        private Fountain _fountain;

        public Player(Fountain fountain) 
        { 
            _fountain = fountain;
        }

        // get player input 
        // player needs to know what room they're in 

        public void ChangeFountainStatus()
        {
            _fountain.State = _fountain.State == FountainState.On ? FountainState.Off : FountainState.On;
        }
    }
}
