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
                    hero.ChooseAction(this, hero).Execute(this, hero);
                    Console.WriteLine($"It is {hero.Name}'s turn...");
                    Thread.Sleep(500);
                    Console.WriteLine();

                }
                foreach (Character monster in Monsters.Characters)
                {
                    monster.ChooseAction(this, monster).Execute(this, monster);
                    Console.WriteLine($"It is {monster.Name}'s turn...");
                    Thread.Sleep(500);
                    Console.WriteLine();

                }
            }
        }
    }
}
