using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    public class AttackAction : IAction
    {
        // Stores the attack being used and on what target
        private IAttack _attack;
        private Character _target;

        public AttackAction(IAttack attack, Character target)
        {
            _attack = attack;
            _target = target;
        }

        // Execute the attack action
        public void Execute(Game game, Character character)
        {
            Console.WriteLine($"{character.Name} used {_attack.Name} on {_target.Name}");
        }

    }
}
