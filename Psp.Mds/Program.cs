using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Psp.Mds
{
    class Program
    {
        public static void Main(string[] args)
        {
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, config) => { })
                .UseUrls("http://localhost:5034/")
                .UseStartup<Startup>().Build().Run();
        }
    }
}
