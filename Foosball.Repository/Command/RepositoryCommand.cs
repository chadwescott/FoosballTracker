using CooperVision.DataAccess.Context;
using Foosball.Domain.Command;

namespace Foosball.Repository.Command
{
    internal abstract class RepositoryCommand : ICommand
    {
        protected readonly IContextFactory<IFoosballContext> ContextFactory = new FoosballContextFactory("DefaultConnection");

        public abstract void Execute();
    }
}
