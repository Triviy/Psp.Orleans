using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Psp.OuterWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, config) => { })
                .UseUrls("http://localhost:5035/")
                .UseStartup<Startup>()
                .Build()
                .Run();
        }
    }
}
