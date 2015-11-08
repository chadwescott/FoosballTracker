using System;
using CooperVision.DataAccess.Repository;
using Foosball.Domain.Command;

namespace Foosball.Repository.Command
{
    internal abstract class RepositoryRead<TD, TR> : RepositoryCommand, ICommandWithResult<TR>
        where TD : class
    {
        protected readonly IRepositoryFactory<TD> RepositoryFactory = new ReadOnlyRepositoryFactory<TD>();

        public TR Result { get; protected set; }

        protected void InvokeRepositoryRead(Action<IRepository<TD>> action)
        {
            using (var context = ContextFactory.CreateContext())
            {
                var repository = RepositoryFactory.CreateRepository(context);
                action(repository);
            }
        }
    }
}
