using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TgdNet
{
    using Microsoft.AspNet.Builder;
    using Microsoft.AspNet.Http;
    using Microsoft.Framework.Configuration;
    using Microsoft.Framework.DependencyInjection;

    public class StartupProduction
    {
        public IConfiguration Configuration { get; set; }

        public void Configure(IApplicationBuilder app)
        {
            app.Run(async context => await context.Response.WriteAsync("Hello World"));
        }

        public void ConfigureServices(IServiceCollection services)
        {
        }

    }
}
