using PlayFlocTestNew.WebApi.Common.Units.Props.Attack.Base;
using PlayFlocTestNew.WebApi.Common.Units.Props.Damage;

namespace PlayFlocTestNew.WebApi.Common.Units.Props.Attack
{
    public class MagicAttack : AttackType
    {
        public MagicAttack(int attackRange) : base(attackRange, new MagicalDamage()) { }
    }
}
