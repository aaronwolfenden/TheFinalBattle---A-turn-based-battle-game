namespace TheFinalBattle
{
    // Main game logic
    public class Game
    {
        private Party Heroes;
        private Party Monsters;

        // Each game consists of a party of heroes and a party of monsters
        public Game(Party heroes, Party monsters)
        {
            Heroes = heroes;
            Monsters = monsters;
        }

        // The main game loop
        public void Run()
        {
            while (!IsOver())
            {

                foreach(Character hero in Heroes.Characters)
                {
                    Console.WriteLine($"It is {hero.Name}'s turn...");
                    Heroes.Player.ChooseAction(this, hero).Execute(this, hero);
                    Thread.Sleep(500);
                    Console.WriteLine();
                    if (IsOver()) break;

                }
                foreach (Character monster in Monsters.Characters)
                {
                    Console.WriteLine($"It is {monster.Name}'s turn...");
                    Monsters.Player.ChooseAction(this, monster).Execute(this, monster);
                    Thread.Sleep(500);
                    Console.WriteLine();
                    if (IsOver()) break;
                }
                if (IsOver()) break;
            }
            DisplayResult();
        }

        public void DisplayResult()
        {
            if (Heroes.Characters.Count == 0)
                Console.WriteLine("The heroes have lost the battle! The Uncoded One's forces have prevailed!");
            else if (Monsters.Characters.Count == 0)
                Console.WriteLine("The heroes have won the battle, but more lie ahead!");
        }

        // Method to check if the game is over
        public bool IsOver() => Heroes.Characters.Count == 0 || Monsters.Characters.Count == 0 ? true : false;
        // Methods to check which party a character belongs to
        public Party GetPartyOf(Character character) => Heroes.Characters.Contains(character) ? Heroes : Monsters;
        public Party GetEnemyPartyOf(Character character) => Heroes.Characters.Contains(character) ? Monsters : Heroes;
    }
}
