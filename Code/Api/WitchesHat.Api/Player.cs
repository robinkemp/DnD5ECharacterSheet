using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using WitchesHat.Domain.Character;
using WitchesHat.Data.Repository.Character;

namespace WitchesHat.Api
{
    public class Player
    {
        public Player(ICharacterRepository characterRepository)
        {
            _characterRepository = characterRepository;
        }

        private ICharacterRepository _characterRepository;

        [FunctionName("GetCharacters")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("GetCharacters called");

            List<Character> characters = new List<Character>();
            characters.Add(Character.Create(Guid.NewGuid(), "Sindri Sparklegem Scheppen"));
            characters.Add(Character.Create(Guid.NewGuid(), "Floats With Clouds"));

            return new OkObjectResult(characters);
        }

        [FunctionName("GetCharactersFromMongo")]
        public async Task<IActionResult> GetCharactersFromMongo(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("GetCharactersFromMongo called");

            return new OkObjectResult(await _characterRepository.Get());
        }
    }
}
