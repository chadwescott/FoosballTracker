using System;
using System.Data.Entity;
using CooperVision.DataAccess.Context;
using Foosball.Repository.Model;

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

        public DbSet<Player> Players { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<PlayerRecord> PlayerRecords { get; set; }
        public DbSet<RatingHistory> RatingHistory { get; set; }
    }
}
