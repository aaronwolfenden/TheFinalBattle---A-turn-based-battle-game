using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    // Action to skip the a turn
    public class SkipAction : IAction
    {
        public void Execute(Game game, Character character)
        {
            Console.WriteLine($"{character.Name} did NOTHING.");
        }
    }
}
