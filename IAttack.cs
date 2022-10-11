using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    // Represents the different types of attacks that will be present within the game
    public interface IAttack
    {
        public string Name { get; }
        // An attack data record is required to store the information of each which implements the interface
        AttackData Create();
    }

    // Record to store any information about an attack (Damage, hit chance, damage type etc.)
    public record AttackData(int Damage);
}
