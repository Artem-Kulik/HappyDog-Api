using HappyDog_Api.Models.Configuration;
using HappyDog_Api.Models.Configuration.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyDog_Api.Helpers
{
    public static class SeedDataExtention
    {
        public static IWebHost SeedDatabase(this IWebHost webHost)
        {
            using (var scope = webHost.Services.CreateScope())
            {
                try
                {
                    var initializer = scope
                        .ServiceProvider
                        .GetRequiredService<IEntityInitializer>();

                    initializer.SeedData().Wait();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return webHost;
        }
    }
}
