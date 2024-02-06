using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FountainOfObjects
{

    // handles running the game 
    // set up all the objects
    // - player
    // - map 
    // handles win condition

    public class Game
    {
        // one fountain for the whole world 
        private static readonly Fountain _fountain = new();
        // one map for the whole world 
        private readonly World _world = new(_fountain);
        // one player for the whole world 
        private readonly Player _player = new(_fountain);


        // change the state to control the loop?
        private bool _win = false;

        // how to know where the player current is
        // and how to know what type of room they're currently in 
        public Game()
        {

        }

        public void Run()
        {
            Console.WriteLine("THE FOUNTAIN OF OBJECTS");

            while (!_win)
            {
                string line = new('-', 100);

                Console.WriteLine(line);
                Console.WriteLine($"You are in the room at: ({_player.CurrentRow},{_player.CurrentColumn}).");
                GetUserInput();
                _world.Map[_player.CurrentRow, _player.CurrentColumn].DisplayRoomMessage();
                _win = CheckWin();
            }

        }


        // what to do when there is so many different interactions that could exist
        // e.g. attack/open door/open chest/unlock chest
        private void GetUserInput()
        {
            Console.Write("What would you like to do? ");

            string? userInput = Console.ReadLine();

            if ( userInput != null )
            {
                if (userInput.Equals("enable fountain", StringComparison.CurrentCultureIgnoreCase))
                {
                    _player.ChangeFountainStatus();
                } else if (userInput.Equals("move west", StringComparison.CurrentCultureIgnoreCase))
                {
                    _player.CurrentColumn--;
                }
                else if (userInput.Equals("move east", StringComparison.CurrentCultureIgnoreCase))
                {
                    _player.CurrentColumn++;
                }
                else if (userInput.Equals("move north", StringComparison.CurrentCultureIgnoreCase))
                {
                    _player.CurrentRow--;
                }
                else if (userInput.Equals("move south", StringComparison.CurrentCultureIgnoreCase))
                {
                    _player.CurrentRow++;
                }
            }
        }

        // only check if in the entrance room?
        // check every loop?
        private bool CheckWin()
        {
            return _fountain.State == FountainState.On && _world.Map[_player.CurrentRow, _player.CurrentColumn].RoomType == RoomType.Entrance;
        }

    }
}
