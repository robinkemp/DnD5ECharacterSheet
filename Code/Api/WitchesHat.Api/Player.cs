using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using WitchesHat.Domain;

namespace WitchesHat.Api
{
    public static class Player
    {
        [FunctionName("GetCharacters")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("GetCharacters called");

            List<Character> characters = new List<Character>();
            characters.Add(Character.Create(Guid.NewGuid(), "Sindri Sparklegem Scheppen"));
            characters.Add(Character.Create(Guid.NewGuid(), "Floats With Clouds"));

            return new OkObjectResult(characters);
        }
    }
}
