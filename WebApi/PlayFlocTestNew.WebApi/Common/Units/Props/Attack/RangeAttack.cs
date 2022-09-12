using PlayFlocTestNew.WebApi.Common.Units.Props.Attack.Base;
using PlayFlocTestNew.WebApi.Common.Units.Props.Damage;

namespace PlayFlocTestNew.WebApi.Common.Units.Props.Attack
{
    public class RangeAttack : AttackType
    {
        public RangeAttack(int attackRange) : base(attackRange, new PhysicalDamage()) { }
    }
}
