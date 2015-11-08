using System.Data.Entity;
using CooperVision.DataAccess.Context;
using Foosball.Repository.Model;

namespace Foosball.Repository
{
    internal interface IFoosballContext : IDbContext
    {
        DbSet<Player> Players { get; set; }
        DbSet<Game> Games { get; set; }
    }
}
