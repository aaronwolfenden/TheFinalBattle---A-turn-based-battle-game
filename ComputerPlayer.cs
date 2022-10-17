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
            // Check that enemies exist in the opposing party, skipping turn if it's empty
            List<Character> enemyList = game.GetEnemyPartyOf(character).Characters;
            if (enemyList.Count == 0) return new SkipAction();
            return new AttackAction(character.Attack, game.GetEnemyPartyOf(character).Characters[0]);
        }
    }
}
