using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    // Uncoded one's attack
    public class UnravelingAttack : IAttack
    {
        // Random to determine hit strength
        private static readonly Random _random = new Random();
        public string Name => "UNRAVELING ATTACK";
        public AttackData Create() => new AttackData(_random.Next(3));
    }
}
