using PlayFlocTestNew.WebApi.Common.Units;
using PlayFlocTestNew.WebApi.Common.Units.Props.Attack;
using PlayFlocTestNew.WebApi.Interfaces.Factories;
using PlayFlocTestNew.WebApi.Interfaces.Units;

namespace PlayFlocTestNew.WebApi.Common.Factories
{
    public class WarriorFactory : IUnitFactory
    {
        public IUnit CreateUnit()
        {
            return new Warrior(new MeleeAttack(10));
        }
    }
}
