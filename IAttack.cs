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
    }
}
