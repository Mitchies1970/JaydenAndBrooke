using Microsoft.Extensions.Configuration;

namespace ConsoleTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            IConfiguration configuration = new ConfigurationBuilder()
              .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true)
              .AddEnvironmentVariables()
              .AddCommandLine(args)
              .Build();

            var _connectionString = configuration
                        .GetSection("CosmosDBConnection")
                        .Get<JnB.BusinessLogic.DTOs.CosmosDBConnection>();

            Console.WriteLine(_connectionString.EndpointUri);

        }
    }
}