namespace TheFinalBattle
{
    // Abstract class that provides a base class for further characters / monsters to be based off
    public abstract class Character
    {
        // Each character requires a name
        public abstract string Name { get; }
        // Each character has their own unique attack
        public abstract IAttack Attack { get; }

    }
}
