using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    public class ComputerPlayer : IPlayer
    {
        IAction ChooseAction(Game game, Character character)
        {
            return new SkipAction();
        }
    }
}
