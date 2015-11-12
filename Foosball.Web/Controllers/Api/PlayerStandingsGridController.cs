using System;
using System.Linq;
using System.Web.Http;
using CooperVision.QueryEngine.Grid;
using CooperVision.QueryEngine.Grid.Response;
using Foosball.Business;
using Foosball.Web.Factory;
using Foosball.Web.Models;

namespace Foosball.Web.Controllers.Api
{
    public class PlayerStandingsGridController : ApiController
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
                    records = result.Select(PlayerRecordViewModelFactory.Make).ToList()
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
    }
}