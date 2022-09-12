using PlayFlocTestNew.WebApi.Interfaces.Units.Props.Attack;
using PlayFlocTestNew.WebApi.Interfaces.Units.Props.Damage;

namespace PlayFlocTestNew.WebApi.Interfaces.Units
{
    public interface IUnit
    {
        IAttackType AttackType { get; }

        int Hp { get; set; }
        int MaxHp { get; set; }
        int Mana { get; set; }
        int MaxMana { get; set; }
        int Armor { get; set; }
        int MagResist { get; set; }
        int X { get; set; }
        int Y { get; set; }

        bool IsDied { get; }

        void GetDamage(IDamageType damage);
        void Attack(IUnit unit);
    }
}
