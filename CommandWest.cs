using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FountainOfObjects
{
    public class CommandWest : ICommand
    {
        public void Execute(Player player)
        {
            if (World.CheckMoveInRange(player.CurrentColumn - 1))
            {
                player.CurrentColumn -= 1;
            }
        }


    }
}
