using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;

namespace DemoForAppConfiguration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureAppConfiguration((hostingContext, config) =>
                    {
                        var settings = config.Build();
                        config.AddAzureAppConfiguration(options =>
                        {
                            options.Connect(settings.GetConnectionString("AppConnectionString"))
                                   .ConfigureRefresh(refresh =>
                                   {
                                       refresh.Register("UpdatedVersion", refreshAll: true)
                                          .SetCacheExpiration(new TimeSpan(0, 0, 10));
                                   });
                        });
                    }).UseStartup<Startup>();
                });
    }
}
