using PlayFlocTestNew.WebApi.Interfaces.Units;
using PlayFlocTestNew.WebApi.Interfaces.Units.Props.Attack;
using PlayFlocTestNew.WebApi.Interfaces.Units.Props.Damage;

namespace PlayFlocTestNew.WebApi.Common.Units.Props.Attack.Base
{
    public abstract class AttackType : IAttackType
    {
        public int AttackRange { get; }
        public IDamageType Damage { get; }

        public AttackType(int attackRange, IDamageType damageType)
        {
            AttackRange = attackRange;
            Damage = damageType;
        }   

        public void Attack(IUnit unit, int damage, int distance)
        {
            if (distance > AttackRange) return;
            Damage.SetDamage(damage);
            unit.GetDamage(Damage);
        }
    }
}
