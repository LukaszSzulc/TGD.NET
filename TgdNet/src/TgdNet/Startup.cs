using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TgdNet
{
    using Microsoft.AspNet.Builder;
    using Microsoft.AspNet.Hosting;
    using Microsoft.AspNet.Http;
    using Microsoft.AspNet.Mvc;
    using Microsoft.AspNet.Mvc.Xml;
    using Microsoft.Dnx.Runtime;
    using Microsoft.Framework.Configuration;
    using Microsoft.Framework.DependencyInjection;

    using TgdNet.Binders;
    using TgdNet.Filters;

    public class Startup
    {
        public Startup(IHostingEnvironment env, IApplicationEnvironment appEnv)
        {
            var configuration =
                new ConfigurationBuilder(appEnv.ApplicationBasePath).AddJsonFile("config.json", false)
                    .AddEnvironmentVariables();
            this.Configuration = configuration.Build();
        }
        public IConfiguration Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.Configure<MvcOptions>(
                options =>
                    {
                        options.RespectBrowserAcceptHeader = true;
                        options.ModelBinders.Add(new IPrincipalBinder());
                        options.Filters.Add(typeof(SampleFilter));
                        options.OutputFormatters.Add(new XmlSerializerOutputFormatter());
                    });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            app.UseMvc(
                builder =>
                    {
                        builder.MapRoute("default", "{controller=Home}/{action=index}/{id?}");
                    });
            //app.UseWelcomePage();
            
        }
    }
}
