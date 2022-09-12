using PlayFlocTestNew.WebApi.Common.Units.Base;
using PlayFlocTestNew.WebApi.Interfaces.Units;
using PlayFlocTestNew.WebApi.Interfaces.Units.Props.Attack;

namespace PlayFlocTestNew.WebApi.Common.Units
{
    public class Mage : Unit
    {
        public Mage(IAttackType attackType) : base(attackType) { }

        public override void Attack(IUnit unit)
        {
            int dist = Eyes.CalcDistance(this, unit);
            int damage = TrySpendManaForAttack();
            AttackType.Attack(unit, damage, dist);
        }
        private int TrySpendManaForAttack()
        {
            if (Mana <= 1) return BaseAttack / 2;
            Mana /= 2;
            return BaseAttack * 2;
        }
    }
}
