namespace FountainOfObjects
{
    public class Fountain
    {
        public FountainState State { get; set; } = FountainState.Off;
    }

    public enum FountainState
    {
        On,
        Off
    }
}
