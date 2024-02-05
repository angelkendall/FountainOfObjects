using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FountainOfObjects
{
    public class Fountain
    {
        public FountainState State { get; set; } = FountainState.Off;

        public Fountain() { }

        public void DisplayFountainState()
        {
            Console.WriteLine($"Fountain is currently: {State}");
        }
    }

    public enum FountainState
    {
        On,
        Off
    }
}
