namespace TheFinalBattle
{
    // Object to store a list of characters as a contained party
    public class Party
    {
        // Each party consists of a group of characters
        public List<Character> Characters { get; } = new List<Character>();
        // Behaviour of the party is determined by whether a ComputerPlayer or a human player
        public IPlayer Player { get; }
        public Party(IPlayer player)
        {
            Player = player;
        }
    }
}
