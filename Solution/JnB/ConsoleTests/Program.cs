using Microsoft.Extensions.Configuration;

namespace ConsoleTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            static async Task Main(string[] args)
            {

                IConfiguration Configuration = new ConfigurationBuilder()
                  .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true)
                  .AddEnvironmentVariables()
                  .AddCommandLine(args)
                  .Build();
            }

        }
    }
}