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
            AttackData attackdata = _attack.Create();
            _target.CurrentHealth -= attackdata.Damage;
            Console.WriteLine($"{_attack.Name} dealt {attackdata.Damage} damage to {_target.Name}");
            Console.WriteLine($"{_target.Name} is now at {_target.CurrentHealth}/{_target.MaximumHealth} HP");

            // Check to see if the character has died
            if (!_target.IsAlive)
            {
                // Display a message that the target has been defeated and then remove them from the party that they belong to
                Console.WriteLine($"{_target.Name} has been defeated!");
                game.GetPartyOf(_target).Characters.Remove(_target);
            }
        }

    }
}
