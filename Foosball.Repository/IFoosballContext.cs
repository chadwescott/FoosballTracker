using System.Data.Entity;
using CooperVision.DataAccess.Context;
using Foosball.Repository.Tables;
using Foosball.Repository.Views;

namespace Foosball.Repository
{
    internal interface IFoosballContext : IDbContext
    {
        DbSet<DbGame> Games { get; set; }
        DbSet<DbGameSummary> GameSummaries { get; set; }
        DbSet<DbPlayer> Players { get; set; }
        DbSet<DbPlayerRecord> PlayerRecords { get; set; }
    }
}
