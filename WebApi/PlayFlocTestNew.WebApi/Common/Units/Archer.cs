using PlayFlocTestNew.WebApi.Common.Units.Base;
using PlayFlocTestNew.WebApi.Interfaces.Units;
using PlayFlocTestNew.WebApi.Interfaces.Units.Props.Attack;

namespace PlayFlocTestNew.WebApi.Common.Units
{
    public class Archer : Unit
    {
        public Archer(IAttackType attackType) : base(attackType) { }

        public override void Attack(IUnit unit)
        {
            int dist = Eyes.CalcDistance(this, unit);
            int attackRange = AttackType.AttackRange;
            int damage = BaseAttack + dist / attackRange * BaseAttack;
            AttackType.Attack(unit, damage, dist);
        }
    }
}
