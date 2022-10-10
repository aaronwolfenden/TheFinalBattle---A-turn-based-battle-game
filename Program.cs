using TheFinalBattle;

// Create a heroes party and add a skeleton to the characters list
Party heroes = new Party(new ComputerPlayer());
Console.Write("What is the name of your character? ");
heroes.Characters.Add(new TrueProgrammer(Console.ReadLine().ToUpper()));

// Create a monsters party and add a skeleton to the characters list
Party monsters = new Party(new ComputerPlayer());
monsters.Characters.Add(new Skeleton());

// Create a game instance
Game game = new Game(heroes, monsters);

// Run the game
game.Run();