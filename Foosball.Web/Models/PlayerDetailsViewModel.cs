using System.Collections.Generic;
using System.Linq;
using Foosball.Domain.Model;

namespace Foosball.Web.Models
{
    public class PlayerDetailsViewModel
    {
        public PlayerDetailsViewModel(IList<IPlayerGameLog> gameLogs)
        {
            GameLogs = gameLogs;

            var data = new List<string> { "[0, 1000]"};
            for (var i = 0; i < gameLogs.Count(); i++)
            {
                var game = gameLogs[i];
                data.Add(string.Format("[{0}, {1}]", i + 1, game.Rating));
            }
            ChartData = string.Format("[{0}]", string.Join(", ", data));
        }

        public IPlayer Player { get; set; }

        public IEnumerable<IPlayerGameLog> GameLogs { get; private set; }

        public string ChartData { get; private set; }
    }
}