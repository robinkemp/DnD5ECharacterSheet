using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;
using WitchesHat.Data.Repository.Character;
using WitchesHat.Data.Services;

[assembly: FunctionsStartup(typeof(WitchesHat.Api.Startup))]

namespace WitchesHat.Api
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var config = new ConfigurationBuilder()
               .SetBasePath(Environment.CurrentDirectory)
               .AddJsonFile("appsettings.json", true)
               .AddJsonFile("local.settings.json", true)
               .AddUserSecrets(Assembly.GetExecutingAssembly(), true)
               .AddEnvironmentVariables()
               .Build();


            builder.Services.AddScoped<IMongoService>((s) => { return new MongoService(config["MongoCluster"],
                config["MongoDatabase"],
                config["MongoUser"],
                config["MongoPassword"]);});

            builder.Services.AddTransient<ICharacterRepository, CharacterRepository>();
        }
    }
}
