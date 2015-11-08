using System;
using CooperVision.DataAccess.Context;

namespace Foosball.Repository
{
    internal class FoosballContextFactory : ContextFactory<IFoosballContext>
    {
        public FoosballContextFactory(String nameOrConnectionString = null, int minCommandTimeout = -1)
            : base(nameOrConnectionString, minCommandTimeout)
        { }
    }
}
