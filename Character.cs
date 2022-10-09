namespace TheFinalBattle
{
    // Abstract class that provides a base class for further characters / monsters to be based off
    public abstract class Character
    {
        public abstract string Name { get; }
        // Logic to take a turn
        public void TakeTurn() => Console.WriteLine($"{Name} did NOTHING");
    }
}
