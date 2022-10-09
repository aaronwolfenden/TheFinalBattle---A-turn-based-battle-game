using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    // An interface for actions to be based off
    public interface IAction
    {
        public void Execute(Game game, Character character) { }
    }
}
