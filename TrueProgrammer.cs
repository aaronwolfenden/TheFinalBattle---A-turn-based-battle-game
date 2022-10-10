using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    // The player's main character
    public class TrueProgrammer : Character
    {
        // String for custom naming of the main character
        public override string Name { get;}
        // The attack the character uses
        public override IAttack Attack => new Punch();
        

        public TrueProgrammer(string name)
        {
            Name = name;
        }

    }
}
