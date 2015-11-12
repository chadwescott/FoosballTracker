using System;
using CooperVision.DataAccess.Repository;
using Foosball.Domain.Command;
using Foosball.Domain.Model;

namespace Foosball.Repository.Command
{
    internal abstract class RepositorySave<T> : RepositoryCommand, ICommandWithResult<T> where T : class, IHasId<Guid>
    {
        protected readonly IRepositoryFactory<T> RepositoryFactory = new WritableRepositoryFactory<T>();
        public T Result { get; protected set; }

        protected RepositorySave(T model)
        {
            Result = model;
        }

        public override void Execute()
        {
            InvokeRepositoryAndSave(repository =>
            {
                if (Result.Id == Guid.Empty)
                    repository.Insert(Result);
                else
                    repository.Update(Result);
            });
        }

        private void InvokeRepositoryAndSave(Action<IRepository<T>> action)
        {
            using (var context = ContextFactory.CreateContext())
            {
                var repository = RepositoryFactory.CreateRepository(context);
                action(repository);
                context.SaveChanges();
            }
        }
    }
}
