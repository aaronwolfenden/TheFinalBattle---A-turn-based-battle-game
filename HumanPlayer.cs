using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    // Implementation of IPlayer for a human player
    public class HumanPlayer : IPlayer
    {
        public IAction ChooseAction(Game game, Character character)
        {
            // List a menu of possible actions and then return an IAction
            Console.WriteLine("1 - Skip Turn");
            Console.WriteLine("2 - Attack");
            Console.Write("What do you want to do? ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (choice == 1) return new SkipAction();
            if (choice == 2)
            {
                int target = ChooseTarget(game, character);
                return new AttackAction(character.Attack, game.GetEnemyPartyOf(character).Characters[target]);
            }
            return new SkipAction();
        }

        public int ChooseTarget(Game game, Character character)
        {
            List<Character> enemyList = game.GetEnemyPartyOf(character).Characters;

            for (int characterNo = 0; characterNo < enemyList.Count; characterNo++)
            {
                Console.WriteLine($"{characterNo} - {enemyList[characterNo].Name} ({enemyList[characterNo].CurrentHealth}/{enemyList[characterNo].MaximumHealth})");
            }
            Console.Write("Choose a target: ");
            int target = Convert.ToInt32(Console.ReadLine());

            return target;
        }
    }
}
