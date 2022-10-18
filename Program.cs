using TheFinalBattle;

// Create a heroes party and add a skeleton to the characters list
Party heroes = new Party(new HumanPlayer());
Console.Write("What is the name of your character? ");
heroes.Characters.Add(new TrueProgrammer(Console.ReadLine().ToUpper()));

// Create a list of monster parties and generate them using methods
List<Party> monsterParties = new List<Party> { CreateMonsterPartyOne(new ComputerPlayer()), CreateMonsterPartyTwo(new ComputerPlayer()), CreateUncodedOne(new ComputerPlayer())};

// Create a game instance for each battle and run the game
for (int i = 0; i < monsterParties.Count; i++)
{
    Party monsters = monsterParties[i];
    Game game = new Game(heroes, monsters);
    game.Run();
    if (heroes.Characters.Count == 0)
    {
        Console.WriteLine("As the last hero falls, a darkness sweeps over the land. The Uncoded One is victorious.");
        break;
    }
}


Party CreateMonsterPartyOne(IPlayer player)
{
    Party monsters = new Party(player);
    monsters.Characters.Add(new Skeleton());
    return monsters;
}

Party CreateMonsterPartyTwo(IPlayer player)
{
    Party monsters = new Party(player);
    monsters.Characters.Add(new Skeleton());
    monsters.Characters.Add(new Skeleton());
    return monsters;
}

Party CreateUncodedOne(IPlayer player)
{
    Party monsters = new Party(player);
    monsters.Characters.Add(new TheUncodedOne());
    return monsters;
}