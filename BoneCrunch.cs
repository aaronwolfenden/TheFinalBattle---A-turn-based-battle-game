using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    // Skeleton default attack
    public class BoneCrunch : IAttack
    {
        // Private readonly random function to determine whether Bonecrunch hits 0 or 1
        private static readonly Random _random = new Random();
        public string Name => "BONE CRUNCH";
        public AttackData Create() => new AttackData(_random.Next(2));
    }
}
