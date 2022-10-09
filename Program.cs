using TheFinalBattle;

// Create a heroes party and add a skeleton to the characters list
Party heroes = new Party();
heroes.Characters.Add(new Skeleton());

// Create a monsters party and add a skeleton to the characters list
Party monsters = new Party();
monsters.Characters.Add(new Skeleton());

// Create a game instance
Game game = new Game(heroes, monsters);

// Run the game
game.Run();