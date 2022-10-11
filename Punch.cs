using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    // Main characters default attack
    public class Punch : IAttack
    {
        public string Name => "PUNCH";
        public AttackData Create() => new AttackData(1);
    }
}
