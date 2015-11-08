using System;

namespace Foosball.Domain.Command
{
    public class CommandExecuter
    {
        protected readonly log4net.ILog Logger =
               log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        protected readonly Guid TransactionId = Guid.NewGuid();

        public void Execute(ICommand command)
        {
            try
            {
                OnBeforeExecute(command);
                command.Execute();
                OnAfterExecute(command);
            }
            catch (Exception ex)
            {
                HandleException(command, ex);
            }
        }

        protected virtual void OnBeforeExecute(ICommand command)
        {
            Logger.Info(string.Format("{0} - {1} Execute Start", TransactionId, command.GetType()));
        }

        protected virtual void OnAfterExecute(ICommand command)
        {
            Logger.Info(string.Format("{0} - {1} Execute Complete", TransactionId, command.GetType()));
        }

        protected virtual void HandleException(ICommand command, Exception ex)
        {
            Logger.Error(string.Format("{0} - {1} Exception: {2}", TransactionId, command.GetType(), ex.Message), ex);
            Logger.Error(ex.Message, ex);
            throw ex;
        }
    }
}
