namespace TheFinalBattle
{
    // Abstract class that provides a base class for further characters / monsters to be based off
    public abstract class Character
    {
        // Each character requires a name
        public abstract string Name { get; }
        // Each character has their own unique attack
        public abstract IAttack Attack { get; }
        // The maximum health value will be passed individually per character type
        public int MaximumHealth { get; }
        // The current health shouldn't be accessible to anything outside of the class
        private int _currentHealth;
        // Reference for when the character is required to take damage, clamp is used to make sure that the health does not exceed the maximum health of the character
        // and not preceed 0 as this would indicate a character death
        public int CurrentHealth 
        { 
            get => _currentHealth; 
            set => _currentHealth = Math.Clamp(value, 0, MaximumHealth); 
        }

        public Character(int maximumHealth)
        {
            MaximumHealth = maximumHealth;
            CurrentHealth = MaximumHealth;
        }
    }
}
