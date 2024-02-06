namespace FountainOfObjects
{
    public class Player(Fountain fountain)
    {
        private readonly Fountain _fountain = fountain;

        // start in entrance
        public int CurrentRow { get; set; } = 0;
        public int CurrentColumn { get; set; } = 0;

        public void ChangeFountainStatus()
        {
            _fountain.State = _fountain.State == FountainState.On ? FountainState.Off : FountainState.On;
        }

        // this should be better
        public static string GetInput()
        {

            Console.Write("What do you want to do? ");
            string? input = Console.ReadLine();

            if (input == null || input.Any(char.IsDigit))
            {
                return "Please enter a valid input.";
            }

            return input.ToLower();
        }

    }
}
