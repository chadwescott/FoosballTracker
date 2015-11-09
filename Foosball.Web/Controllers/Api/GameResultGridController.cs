using System;
using System.Linq;
using System.Web.Http;
using CooperVision.QueryEngine.Grid;
using CooperVision.QueryEngine.Grid.Response;
using Foosball.Business;
using Foosball.Domain.Model;
using Foosball.Web.Models;

namespace Foosball.Web.Controllers.Api
{
    public class GameResultGridController : ApiController
    {
        public BaseResponse Post([FromBody]PostData<GameViewModel> data)
        {
            switch (data.cmd)
            {
                case "get-records":
                    return GetResults(data);
            }

            return null;
        }

        protected virtual BaseResponse GetResults(PostData<GameViewModel> data)
        {
            try
            {
                var commands = new FoosballCommands();
                var result = commands.GetGames().OrderByDescending(g => g.Timestamp).ToList();

                return new GetResponse<GameViewModel>
                {
                    status = ResponseCodes.Success,
                    total = result.Count(),
                    records = result.Select(CreateViewModel).ToList()
                };
            }
            catch (Exception ex)
            {
                return new ErrorResponse
                {
                    status = ResponseCodes.Error,
                    message = ex.Message
                };
            }
        }

        private static GameViewModel CreateViewModel(IGame model)
        {
            return new GameViewModel
            {
                Id = model.Id,
                Loser = model.Loser,
                LoserId = model.Loser.Id,
                LoserScore = model.LoserScore,
                Timestamp = model.Timestamp,
                Winner = model.Winner,
                WinnerId = model.Winner.Id,
                WinnerScore = model.WinnerScore
            };
        }
    }
}