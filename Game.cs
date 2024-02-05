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
        private static readonly Fountain _fountain= new();

        private readonly World _map = new(_fountain);
        private readonly Player _player = new(_fountain);
        public Game()
        {

        }

        public void Run()
        {
            Console.WriteLine("THE FOUNTAIN OF OBJECTS");


            _map.Display();

            _player.ChangeFountainStatus();


        }


    }
}
