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
        public BaseResponse Post([FromBody]PostData<GamesViewModel> data)
        {
            switch (data.cmd)
            {
                case "get-records":
                    return GetResults(data);
            }

            return null;
        }

        protected virtual BaseResponse GetResults(PostData<GamesViewModel> data)
        {
            try
            {
                var commands = new FoosballCommands();
                var result = commands.GetGames().OrderByDescending(g => g.Timestamp).ToList();

                return new GetResponse<GamesViewModel>
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

        private static GamesViewModel CreateViewModel(IGame model)
        {
            return new GamesViewModel
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