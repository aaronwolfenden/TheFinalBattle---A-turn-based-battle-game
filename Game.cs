namespace TheFinalBattle
{
    // Main game logic
    public class Game
    {
        private Party Heroes;
        private Party Monsters;

        public Game(Party heroes, Party monsters)
        {
            Heroes = heroes;
            Monsters = monsters;
        }

        public void Run()
        {
            while (true)
            {
                foreach(Character hero in Heroes.Characters)
                {
                    hero.TakeTurn();
                    Console.WriteLine($"It is {hero.Name}'s turn...");
                    Thread.Sleep(500);
                    Console.WriteLine();

                }
                foreach (Character monster in Monsters.Characters)
                {
                    monster.TakeTurn();
                    Console.WriteLine($"It is {monster.Name}'s turn...");
                    Thread.Sleep(500);
                    Console.WriteLine();

                }
            }
        }
    }
}
