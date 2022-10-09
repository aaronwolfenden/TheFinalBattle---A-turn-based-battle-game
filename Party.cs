namespace TheFinalBattle
{
    // Object to store a list of characters as a contained party
    public class Party
    {
        public List<Character> Characters { get; } = new List<Character>();
        public IPlayer Player { get; }
        public Party(IPlayer player)
        {
            Player = player;
        }
    }
}
