using System.ComponentModel.DataAnnotations.Schema;
using Foosball.Domain.Model;

namespace Foosball.Repository.Model
{
    [Table("V_PlayerRecords")]
    internal class PlayerRecord : Player, IPlayerRecord
    {
        public int Wins{ get; set; }

        public int Losses { get; set; }

        public int GoalsScored { get; set; }

        public int GoalsAllowed { get; set; }

        private IPlayer _player;

        [NotMapped]
        public IPlayer Player {
            get
            {
                return _player ?? (_player = new Player
                {
                    Id = Id,
                    FirstName = FirstName,
                    LastName = LastName
                });
            }
        }
    }
}
