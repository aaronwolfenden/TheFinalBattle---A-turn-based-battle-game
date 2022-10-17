using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    public class TheUncodedOne : Character
    {
        public override string Name => "THE UNCODED ONE";
        public override IAttack Attack => new UnravelingAttack();

        public TheUncodedOne() : base(15) { }
    }
}
