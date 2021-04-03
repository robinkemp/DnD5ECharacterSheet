using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using WitchesHat.Data.Repository.Player;
using Newtonsoft.Json;
using WitchesHat.Domain.Player;

namespace WitchesHat.Api
{
    public class PlayerFunctions
    {
        public PlayerFunctions(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        private IPlayerRepository _playerRepository;

        [FunctionName("GetPlayers")]
        public async Task<IActionResult> GetPlayers(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("GetPlayers called");

            return new OkObjectResult(await _playerRepository.Get());
        }


        [FunctionName("GetPlayerFromSub")]
        public async Task<IActionResult> GetPlayerFromSub(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("GetPlayerFromSub called");
            string sub = req.Query["sub"];
            return new OkObjectResult(await _playerRepository.GetPlayerFromSub(sub));
        }

        [FunctionName("RegisterPlayer")]
        public async Task<IActionResult> RegisterPlayer(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("RegisterPlayer called");
            string json = await req.ReadAsStringAsync();
            var player = JsonConvert.DeserializeObject<Player>(json);
            return new OkObjectResult(await _playerRepository.Create(player));
        }
    }
}
