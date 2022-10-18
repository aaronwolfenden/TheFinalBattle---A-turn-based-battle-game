using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    // An interface which both human and computer players are built off
    public interface IPlayer
    {
        IAction ChooseAction(Game game, Character character)
        {
            return new SkipAction();
        }
    }
}
