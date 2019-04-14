using System.ComponentModel.DataAnnotations.Schema;
using Foosball.Domain.Model;
using Foosball.Repository.Tables;

namespace Foosball.Repository.Views
{
    [Table("V_PlayerRecords")]
    internal class DbPlayerRecord : DbPlayer, IPlayerRecord
    {
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsAllowed { get; set; }
    }
}
