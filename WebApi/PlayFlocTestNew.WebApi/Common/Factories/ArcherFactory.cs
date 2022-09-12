using PlayFlocTestNew.WebApi.Common.Units;
using PlayFlocTestNew.WebApi.Common.Units.Props.Attack;
using PlayFlocTestNew.WebApi.Interfaces.Factories;
using PlayFlocTestNew.WebApi.Interfaces.Units;

namespace PlayFlocTestNew.WebApi.Common.Factories
{
    public class ArcherFactory : IUnitFactory
    {
        public IUnit CreateUnit()
        {
            return new Archer(new RangeAttack(350));
        }
    }
}
