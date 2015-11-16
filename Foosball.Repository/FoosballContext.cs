using System;
using System.Data.Entity;
using CooperVision.DataAccess.Context;
using Foosball.Repository.Tables;
using Foosball.Repository.Views;

namespace Foosball.Repository
{
    internal class FoosballContext : BaseDbContext, IFoosballContext
    {
        public FoosballContext(string nameOrConnectionString = null, int minCommandTimeout = -1)
            : base(nameOrConnectionString)
        {
            Initialize(minCommandTimeout);
        }

        private void Initialize(int minCommandTimeout)
        {
            Database.CommandTimeout = Math.Max(Database.Connection.ConnectionTimeout, minCommandTimeout);
        }

        public DbSet<DbGame> Games { get; set; }
        public DbSet<DbGameSummary> GameSummaries { get; set; }
        public DbSet<DbPlayerGameLog> PlayerGameLogs { get; set; }
        public DbSet<DbPlayer> Players { get; set; }
        public DbSet<DbPlayerRecord> PlayerRecords { get; set; }
    }
}
