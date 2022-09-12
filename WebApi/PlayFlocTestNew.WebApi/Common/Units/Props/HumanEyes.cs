using PlayFlocTestNew.WebApi.Interfaces.Units;
using PlayFlocTestNew.WebApi.Interfaces.Units.Props;

namespace PlayFlocTestNew.WebApi.Common.Units.Props
{
    public class HumanEyes : IEyes
    {
        public int CalcDistance(IUnit me, IUnit target)
        {
            int xDif = Math.Abs(me.X - target.X);
            int yDif = Math.Abs(me.Y - target.Y);
            int hyp = (int)(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));

            return (int)Math.Sqrt(hyp);
        }
    }
}
