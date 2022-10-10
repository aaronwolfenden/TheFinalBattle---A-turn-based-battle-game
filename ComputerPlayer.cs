using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    // Implements the IPlayer interface to represent if a party is controlled by the computer
    public class ComputerPlayer : IPlayer
    {
        public IAction ChooseAction(Game game, Character character)
        {
            return new AttackAction(character.Attack, game.GetEnemyPartyOf(character).Characters[0]);
        }
    }
}
