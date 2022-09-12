using PlayFlocTestNew.WebApi.Common.Units.Base;
using PlayFlocTestNew.WebApi.Interfaces.Units;
using PlayFlocTestNew.WebApi.Interfaces.Units.Props.Attack;

namespace PlayFlocTestNew.WebApi.Common.Units
{
    public class Warrior : Unit
    {
        public Warrior(IAttackType attackType) : base(attackType) { }

        public override void Attack(IUnit unit)
        {
            int dist = Eyes.CalcDistance(this, unit);
            int damage = BaseAttack + (MaxHp - Hp) / MaxHp * BaseAttack;
            AttackType.Attack(unit, damage, dist);
        }
    }
}
