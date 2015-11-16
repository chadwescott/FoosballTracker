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
    public class PlayerGamesGridController : ApiController
    {
        public BaseResponse Post(Guid id, [FromBody]PostData<GameViewModel> data)
        {
            switch (data.cmd)
            {
                case "get-records":
                    return GetResults(id, data);
            }

            return null;
        }

        protected virtual BaseResponse GetResults(Guid id, PostData<GameViewModel> data)
        {
            try
            {
                var commands = new FoosballCommands();
                var result = commands.GetGamesByPlayerId(id).OrderByDescending(g => g.Timestamp).ToList();

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
                LoserDelta = model.LoserDelta,
                LoserId = model.Loser.Id,
                LoserRating = model.LoserRating,
                LoserScore = model.LoserScore,
                Timestamp = model.Timestamp,
                Winner = model.Winner,
                WinnerDelta = model.WinnerDelta,
                WinnerId = model.Winner.Id,
                WinnerRating = model.WinnerRating,
                WinnerScore = model.WinnerScore
            };
        }
    }
}