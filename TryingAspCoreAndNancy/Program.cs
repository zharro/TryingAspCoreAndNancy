using Microsoft.AspNetCore.Hosting;

namespace TryingAspCoreAndNancy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .UseUrls(args)
                .Build();

            host.Run();
        }
    }
}
