using PlayFlocTestNew.WebApi.Interfaces.Units.Props.Damage;

namespace PlayFlocTestNew.WebApi.Common.Units.Props.Damage.Base
{
    public abstract class DamageType : IDamageType
    {
        public int Damage { get; private set; }

        public void SetDamage(int damagePoint)
        {
            Damage = damagePoint;
        }
    }
}
