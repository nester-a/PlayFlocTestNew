using PlayFlocTestNew.WebApi.Interfaces.Units.Props.Damage;

namespace PlayFlocTestNew.WebApi.Interfaces.Units.Props.Attack
{
    public interface IAttackType
    {
        int AttackRange { get; }
        IDamageType Damage { get; }
        void Attack(IUnit unit, int damage, int distance);
    }
}
