using Asp.NetCore;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

public class Program
{
    public static void Main(string[] args)
    {
        //changes by bipin
        CreateWebHostBuilder(args).Build().Run();
        //changes by b2
        //Changes by Harshdeep
        //changes by ANuj
        //changes by b1
    }

    public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>();
}
