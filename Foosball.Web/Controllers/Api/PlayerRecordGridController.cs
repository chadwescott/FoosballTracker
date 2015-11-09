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
    public class PlayerRecordGridController : ApiController
    {
        public BaseResponse Post([FromBody]PostData<PlayerRecordViewModel> data)
        {
            switch (data.cmd)
            {
                case "get-records":
                    return GetResults(data);
            }

            return null;
        }

        protected virtual BaseResponse GetResults(PostData<PlayerRecordViewModel> data)
        {
            try
            {
                var commands = new FoosballCommands();
                var result = commands.GetPlayerRecords().OrderByDescending(r => r.Wins).ToList();

                return new GetResponse<PlayerRecordViewModel>
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

        private static PlayerRecordViewModel CreateViewModel(IPlayerRecord model)
        {
            return new PlayerRecordViewModel
            {
                Player = model.Player,
                Wins = model.Wins,
                Losses = model.Losses,
                GoalsAllowed = model.GoalsAllowed,
                GoalsScored = model.GoalsScored
            };
        }
    }
}