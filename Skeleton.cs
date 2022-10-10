
namespace TheFinalBattle
{
    // Skeleton monster which inherits from the base character class
    public class Skeleton : Character
    {
        public override string Name => "SKELETON";
        public override IAttack Attack => new BoneCrunch();
    }
}
