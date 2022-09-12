using PlayFlocTestNew.WebApi.Common.Units.Props;
using PlayFlocTestNew.WebApi.Common.Units.Props.Damage;
using PlayFlocTestNew.WebApi.Interfaces.Units;
using PlayFlocTestNew.WebApi.Interfaces.Units.Props;
using PlayFlocTestNew.WebApi.Interfaces.Units.Props.Attack;
using PlayFlocTestNew.WebApi.Interfaces.Units.Props.Damage;

namespace PlayFlocTestNew.WebApi.Common.Units.Base
{
    public abstract class Unit : IUnit
    {
        protected int BaseAttack { get; } = 100;
        public IAttackType AttackType { get; }
        public IEyes Eyes { get; }
        public Unit(IAttackType attackType)
        {
            AttackType = attackType;
            Eyes = new HumanEyes();
            IsDied = false;
        }
        public int Hp { get; set; }
        public int MaxHp { get; set; }
        public int Mana { get; set; }
        public int MaxMana { get; set; }
        public int Armor { get; set; }
        public int MagResist { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsDied { get; private set; }

        public abstract void Attack(IUnit unit);

        public void GetDamage(IDamageType damage)
        {
            switch (damage)
            {
                case PhysicalDamage:
                    GetPhysicalDamage(damage.Damage);
                    break;
                case MagicalDamage:
                    GetMagicalDamage(damage.Damage);
                    break;
                default: break;
            }
        }

        private void GetPhysicalDamage(int damage)
        {
            var currentDamage = damage - Armor;
            CalcDamage(currentDamage);
        }
        private void GetMagicalDamage(int damage)
        {
            var currentDamage = damage - MagResist;
            CalcDamage(currentDamage);

        }
        private void CalcDamage(int damage)
        {
            if (damage > Hp)
            {
                Hp = 0;
                IsDied = true;
            }
            else Hp -= damage;
        }
    }
}
